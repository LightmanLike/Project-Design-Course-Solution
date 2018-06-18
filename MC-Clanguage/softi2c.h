#ifndef CC2541_SOFTI2C_H_

#define CC2541_SOFTI2C_H_



#include <stdint.h>
#include <stdbool.h>
#include "inc/hw_types.h"
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"



#define SCL                            GPIO_PIN_2// P1_5                //定义模拟IIC的时钟线

#define SDA                            GPIO_PIN_3// P1_6                //定义模拟IIC的数据线



#define SDA_0                           GPIOPinWrite(GPIO_PORTB_BASE,GPIO_PIN_3,0)//(P1_6=0) //SDA=0

#define SDA_1                           GPIOPinWrite(GPIO_PORTB_BASE,GPIO_PIN_3,GPIO_PIN_3)//(P1_6=1)  //SDA=1

#define SCL_0                           GPIOPinWrite(GPIO_PORTB_BASE,GPIO_PIN_2,0)//(P1_5=0) //SCL=0

#define SCL_1                           GPIOPinWrite(GPIO_PORTB_BASE,GPIO_PIN_2,GPIO_PIN_2)//(P1_5=1)  //SCL=1

#define SDA_R_1                         GPIOPinRead(GPIO_PORTB_BASE,GPIO_PIN_3)


#define SDA_IN                          GPIOPinTypeGPIOInput(GPIO_PORTB_BASE,GPIO_PIN_3)//P1DIR &= ~BIT6 //SDA INPUT

#define SDA_OUT                         GPIOPinTypeGPIOOutputOD(GPIO_PORTB_BASE,GPIO_PIN_3)//P1DIR |= BIT6  //SDA OUTPUT

#define SCL_IN                          GPIOPinTypeGPIOInput(GPIO_PORTB_BASE,GPIO_PIN_2)//P1DIR &= ~BIT5 //SCL INPUT

#define SCL_OUT                         GPIOPinTypeGPIOOutput(GPIO_PORTB_BASE,GPIO_PIN_2)//P1DIR |= BIT5  //SCL OUTPUT



#define I2C_SDA_READ			(P1 & BIT6)



void DelayMS(uint16_t msec);

void delay_1ms(void);

void IIC_Init(void);

void stop(void);

void start(void);

void send_noack(void);

void send_ack(void);

void iic_write(uint8_t datIn);

uint8_t check_ack(void);

uint8_t iic_read(void);









#endif
