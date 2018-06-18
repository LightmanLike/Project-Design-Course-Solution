#ifndef TCS34725_file_H_
#define TCS34725_file_H_

#define SLAVE_ADDRESS 0x29
#define D1 GPIO_PIN_1

#define TCS34725_ENABLE_AEN                     0x02
#define TCS34725_ENABLE_PON                     0x01

#define TCS34725_ENABLE                                     0xA0                    //???????
#define TCS34725_ATIME                          0xA1                    //ATIME???  ??????
#define TCS34725_CONTROL                                    0xAF                    //?????  ??????
#define TCS34725_ID                                             0xB2                    //ID?????
#define TCS34725_STATUS                         0xB3                    //???????


#define TCS34725_ENABLE_AEN                     0x02                //??GBRC
#define TCS34725_ENABLE_PON                     0x01                //??Power

#define TCS34725_STATUS_AINT                    0x10                //RGBC Clean channel interrupt
#define TCS34725_STATUS_AVALID                  0x01                //Indicates that the RGBC channels have completed an integration cycle

#define TCS34725_CDATAL                         0x14                //Clear channel data
#define TCS34725_CDATAH                         0x15
#define TCS34725_RDATAL                         0x16                //Red channel data
#define TCS34725_RDATAH                         0x17
#define TCS34725_GDATAL                         0x18                //Green channel data
#define TCS34725_GDATAH                         0x19
#define TCS34725_BDATAL                         0x1A                //Blue channel data
#define TCS34725_BDATAH                         0x1B
#define RED_ADDR 0xB6
#define BLUE_ADDR 0xBA
#define GREEN_ADDR 0xB8
#define TCS34725_ID_value                                   0x44                    //TCS34735?ID?0x44

#define TCS34725_INTEGRATIONTIME_2_4MS      0xFF                //2.4ms --   1 cycle  -- 1024
#define TCS34725_INTEGRATIONTIME_24MS       0xF6                //24ms  --  10 cycles -- 10240
#define TCS34725_INTEGRATIONTIME_101MS      0xD5                //101ms --  42 cycles -- 43008
#define TCS34725_INTEGRATIONTIME_154MS      0xC0                //154ms --  64 cycles -- 65535
#define TCS34725_INTEGRATIONTIME_700MS      0x00                //700ms -- 256 cycles -- 65535

#define TCS34725_GAIN_1X                    0x00                // 1x gain
#define TCS34725_GAIN_4X                    0x01                // 4x gain
#define TCS34725_GAIN_16X                   0x02                //16x gain
#define TCS34725_GAIN_60X                   0x03                //60x gain
void Delay_ms(uint32_t ui32Seconds);
void I2CMasterWriteTCS34725(uint8_t *pui8data,uint8_t ui8SlaveAddress,		//写
                        uint8_t ui8TCSAddress, uint32_t ui32Count);
void I2CMasterReadTCS34725(uint8_t *pui8data,uint8_t ui8SlaveAddress,		//读
                        uint8_t ui8TCSAddress, uint32_t ui32Count);
void TCS34725_Enable(void);													//唤醒

void TCS34725_SetIntegrationTime(uint8_t time);								//PMT加电、曝光的时间，测量方式可以是光子计数，也可以是光电流测量。
void TCS34725_SetGain(uint8_t ui8gain);
#endif
