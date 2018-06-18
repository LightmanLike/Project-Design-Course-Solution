#include <stdint.h>
#include <stdbool.h>
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "driverlib/gpio.h"
#include "driverlib/sysctl.h"
#include "driverlib/pwm.h"
#include "inc/hw_ints.h"
#include "driverlib/interrupt.h"
#include "driverlib/timer.h"
#include "driverlib/uart.h"
#include "driverlib/pin_map.h"
#include "driverlib/rom_map.h"
#include "inc/hw_i2c.h"
#include "driverlib/i2c.h"
#include "utils/uartstdio.h"
#include "utils/softi2c.h"
#include "driverlib/systick.h"
#include "driverlib/rom.h"
#include "inc/hw_nvic.h"
#include "driverlib/fpu.h"
#include "TCS34725_file.h"
#include "softi2c.h"
#include "vl6180x_i2c.h"
uint8_t distance=0;

uint8_t data_staus=0, data_id;

uint16_t light;


uint32_t g_ui32SysClock;

void
UARTSend(const uint8_t *pui8Buffer, uint32_t ui32Count)
{
    //
    // Loop while there are more characters to send.
    //
    while(ui32Count--)
    {
        //
        // Write the next character to the UART.
        //
        UARTCharPutNonBlocking(UART0_BASE, *pui8Buffer++);
    }
}
void distance_show(void)
{
    int distance_7;
    int distance_6;
    int distance_5;
    int distance_4;
    int distance_0;
    int distance_3;
    int distance_2;
    int distance_1;




    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOB);                 //设置系统时钟源
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPION);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);
    IIC_Init();

    VL6180X_Init();
    GPIOPinTypeGPIOOutput(GPIO_PORTN_BASE,GPIO_PIN_0|GPIO_PIN_1);
    GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE,GPIO_PIN_0|GPIO_PIN_4);

        data_id = VL6180X_CheckID();  // 0x03

        distance = RangePollingRead();
        distance_7 = (distance >> 7) & 0x01;
        distance_6 = (distance >> 6) & 0x01;
        distance_5 = (distance >> 5) & 0x01;
        distance_4 = (distance >> 4) & 0x01;
        distance_3 = (distance >> 3) & 0x01;
        distance_2 = (distance >> 2) & 0x01;
        distance_1 = (distance >> 1) & 0x01;
        distance_0 = distance & 0x01;
        GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_1,distance_7);
        GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_0,distance_6);
        GPIOPinWrite(GPIO_PORTF_BASE,GPIO_PIN_4,distance_5);
        GPIOPinWrite(GPIO_PORTF_BASE,GPIO_PIN_0,distance_4);
        UARTCharPutNonBlocking(UART0_BASE, distance_7);
        UARTCharPutNonBlocking(UART0_BASE, distance_6);
        UARTCharPutNonBlocking(UART0_BASE, distance_5);
        UARTCharPutNonBlocking(UART0_BASE, distance_4);
        UARTCharPutNonBlocking(UART0_BASE, distance_3);
        UARTCharPutNonBlocking(UART0_BASE, distance_2);
        UARTCharPutNonBlocking(UART0_BASE, distance_1);
        UARTCharPutNonBlocking(UART0_BASE, distance_0);
        UARTCharPutNonBlocking(UART0_BASE, distance);
        DelayMS(200);





}
int main(void)
{
    //
    // Set the clocking to run directly from the crystal at 120MHz.
    //
        uint8_t readdata[3];										//读数据
    g_ui32SysClock = SysCtlClockFreqSet((SYSCTL_XTAL_25MHZ |
                                             SYSCTL_OSC_MAIN |
                                             SYSCTL_USE_PLL |
                                             SYSCTL_CFG_VCO_480), 120000000);

        SysTickPeriodSet(SysCtlClockGet());
        SysTickEnable();
    //
    // Enable the GPIO port that is used for the on-board LED.
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPION);
        SysCtlPeripheralEnable(SYSCTL_PERIPH_I2C2);
        SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOB);

        GPIOPinConfigure(GPIO_PN5_I2C2SCL);
        GPIOPinConfigure(GPIO_PN4_I2C2SDA);

    //
    // Enable the GPIO pins for the LED (PN0).
    //

        GPIOPinTypeGPIOOutput(GPIO_PORTN_BASE,D1);
        GPIOPinTypeI2C(GPIO_PORTN_BASE,GPIO_PIN_4);
        GPIOPinTypeI2CSCL(GPIO_PORTN_BASE,GPIO_PIN_5);

    //
    // Enable the peripherals used by this example.
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);

    //
    // Enable processor interrupts.
    //
    IntMasterEnable();

    //
    // Set GPIO A0 and A1 as UART pins.
    //
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    //
    // Configure the UART for 115,200, 8-N-1 operation.
    //
    UARTConfigSetExpClk(UART0_BASE, g_ui32SysClock, 115200,
                            (UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE |
                             UART_CONFIG_PAR_NONE));

    //
    // Enable the UART interrupt.
    //
    IntEnable(INT_UART0);
    UARTIntEnable(UART0_BASE, UART_INT_RX | UART_INT_RT);


        I2CMasterInitExpClk(I2C2_BASE,SysCtlClockGet(),false);

        //TCS34725_Disable();

        TCS34725_Enable();

        TCS34725_SetIntegrationTime(TCS34725_INTEGRATIONTIME_700MS);
        TCS34725_SetGain(TCS34725_GAIN_4X);
        Delay_ms(1000);
        while(1)
        {

            I2CMasterReadTCS34725(readdata,SLAVE_ADDRESS,RED_ADDR,1);//RED_ADDR BLUE_ADDR GREEN_ADDR
            Delay_ms(1000);
            I2CMasterReadTCS34725(&readdata[1],SLAVE_ADDRESS,GREEN_ADDR,1);//RED_ADDR BLUE_ADDR GREEN_ADDR
            Delay_ms(1000);
            I2CMasterReadTCS34725(&readdata[2],SLAVE_ADDRESS,BLUE_ADDR,1);//RED_ADDR BLUE_ADDR GREEN_ADDR
            Delay_ms(1000);
        UARTCharPutNonBlocking(UART0_BASE, readdata[0]);
        UARTCharPutNonBlocking(UART0_BASE, readdata[1]);
        UARTCharPutNonBlocking(UART0_BASE, readdata[2]);
        Delay_ms(1000);
//      if( (readdata[1]>0x15) && (readdata[1]<0x30) )  //yellow
//          ROM_UARTCharPutNonBlocking(UART0_BASE, 1);
//      if( (readdata[1]>0x05) && (readdata[1]<0x15) )   //red
        distance_show();
        Delay_ms(10000);
//          ROM_UARTCharPutNonBlocking(UART0_BASE, 0);
    }

}

