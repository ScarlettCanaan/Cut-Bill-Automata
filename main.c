/**
  ******************************************************************************
  * @file    FMC_SDRAM/main.c 
  * @author  MCD Application Team
  * @version V1.0.1
  * @date    11-November-2013
  * @brief   This example shows how to write to the external SDRAM with 
  *          8bits AHB transaction or 16bits AHB transaction.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; COPYRIGHT 2013 STMicroelectronics</center></h2>
  *
  * Licensed under MCD-ST Liberty SW License Agreement V2, (the "License");
  * You may not use this file except in compliance with the License.
  * You may obtain a copy of the License at:
  *
  *        http://www.st.com/software_license_agreement_liberty_v2
  *
  * Unless required by applicable law or agreed to in writing, software 
  * distributed under the License is distributed on an "AS IS" BASIS, 
  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  * See the License for the specific language governing permissions and
  * limitations under the License.
  *
  ******************************************************************************
  */

/* Includes ------------------------------------------------------------------*/
#include "stm32f4xx.h"
#include "main.h"
#include "sys.h"
#include "usart.h
#include "defines.h"
#include <stdio.h>
#include "image_typedef.h"
	int x0,x1,x2;
	int x10,x11,x12,x13,x14,x15,x16;
	int x30,x31,x32,x33,x34,x35,x36;
	int x40,x41,x42,x43,x44,x45;
SystemInit();
Serial cam(PA_9, PA_10);    //uart for camera
Serial pc(SERIAL_TX, SERIAL_RX);    //uart for usb comport
DigitalOut myled(LED1);
DigitalIn  btn(USER_BUTTON);
DigitalIn button(PC_13); //user open button


int ImgCmd(char c, int Lx, int Ly, int Rx, int Ry, Image_Profile_TypeDef* Img);
int Send_Image_toMem(Image_Profile_TypeDef* ImgProfile);
int Take_photo();
int main(void)
{   

	Serial cam(PA_9, PA_10);    //uart for camera
	Serial pc(SERIAL_TX, SERIAL_RX);    //uart for usb comport
	DigitalOut myled(LED1);
	DigitalIn  btn(USER_BUTTON);
	DigitalIn button(PC_13); //user open button
    Timer timer;
     while(1)
	 {
		 grafcet0();
     }
}
int grafcet0()
{  

	x0=1;
	if(x0==1&&button=1){x1=1;x0=0;}
    else if(x1==0&&btn=1){x2=1;x1=0;}
    else if(x2==0&&button=0){x1=1;x2=0;}
	else if(x2==0&&button=1){x0=1;x2=0;}
action0();
}
int action0() 
{
	  if(x0==1){};
    else if(x1==1)open_state();
    else if(x2==1)grafcet1();
}
void grafcet1()//cut bill system
{
	x10=1;
    if(x10==1){x11=1;x10=0;}
    else if(x11==0){x12=1;x11=0;}
    else if(x12==0){x13=1;x12=0;}
	else if(x13==0){x14=1;x13=0;}
    else if(x14==0){x15=1;x14=0;}
	else if(x15==0){x16=1;x15=0;}
    else if(x16==0){x10=1;x16=0;}
action3();
}
void action1()
{
    if(x10==1){}
    else if(x11==1)Take_photo()
    else if(x12==1)grafcet3();//preprocess_
    else if(x13==1)read_FroFPGA();
    else if(x14==1)formating();
    else if(x15==1)grafcet4();//orc_
    else if(x16==1)output();
}
void grafcet3()  //preprocess
{
 x30=1;
if(x30==1){x31=1;x30=0;}
else if(x31==0){x32=1;x31=0;}
else if(x32==0){x30=1;x32=0;}
else if(x33==0){x34=1;x33=0;}
else if(x34==0){x35=1;x34=0;}
else if(x35==0){x36=1;x35=0;}
else if(x36==0){x30=1;x36=0;}
action3();
}
void action3()
{
    if(x10==1){}
    else if(x31==1)check_fpga()
    else if(x32==1)Remove_noise();
    else if(x33==1)Binaryzation();
    else if(x34==1)Edge_detection();
    else if(x35==1)Image_tilt_correction();
    else if(x36==1)cutting();  
}
void grafcet4() //orc_
{ x40=0;
  if(x40==1){x40=0;x41=1;x43=1}
  else if(x41==1){x41=0;x42=1;}
  else if(x43==1){x43=0;x44=1;}
  else if(x42==1&&x44=1&&Data_ready=1&&Datainfo_ready=1){x42=0;x44=0;x45=1;}
  else if(x45==1){x45=0;x40=1;}

  action4();
}
void action4()
{
   if(x40==1){}
  else if(x41==1)Feature_Extraction();
  else if(x42==1)modeling();
  else if(x43==1)Feature_Extraction_of_Application_Database();
  else if(x44==1)Modeling_of_Application_Database();
  else if(x45==1)Classification_and_identification();
}

void out_put(){}
void check_fpga(){}
void Binaryzation(){}
void Image_tilt_correction(){}
void cutting(){}
void Remove_noise(){}
void Edge_detection)_{}




int Check_Data(uint8_t pixcnt)
{ 
	
	uint32_t i = 0x00000058, shift = 0x00000008,inis=0;
	int m,n,j,retr,ida;
	uint8_t r[320][241];
	 for (j=0;j<10;j++)
	 {
		 r[0][j]=*(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + inis) ;
	     inis = inis + shift;
     }
	 for (j=0;j<=5;j++)
	 {
		 retr=write_succ(r[0][j],ImgFormat[j]);
		 if(retr==0)
			 return 0;
	 }	 
		/*while (STM_EVAL_PBGetState(BUTTON_USER) != Bit_SET){}
		while (STM_EVAL_PBGetState(BUTTON_USER) != Bit_RESET){}*/
     for (m=1;m<=320;m++){  
	    for (n=0;n<=240;n++)
		{
		ida=(m-1)*320+n;
		r[m][n]=*(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i) ;
	    retr=write_succ(r[m][n],Imgdata[ida]);
		 if(retr==0)
			 return 0;
		i = i + shift;
		if(i>0x00ffffff){i=0;}
		}
	 }
	return 1;	
	
}
	
	

#ifdef  USE_FULL_ASSERT

/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
int write_succ(uint8_t a,uint8_t b)
{ if (a==b)
	return 0;
else
	return 1;
	
}
  
void assert_failed(uint8_t* file, uint32_t line)
{
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */

  while (1)
  {}
}
#endif
void open_state()
{
	cam.baud(115200);
	cam.format(8, SerialBase::None, 1);
    pc.baud(115200);
}
int Take_photo() 
{
  int i, errorFlag=0;
  Image_Profile_TypeDef image;
 //image.ColorSpace = binary;   //for rgb image
  image.ColorSpace = GrayScale; //for grayscale, binary image
 int leftx = 0, lefty = 0,rightx = 320, righty = 240; // RGB leftx = 80, lefty = 60,rightx = 240,righty = 180;
 // int leftx = 80, lefty = 60,rightx = 240,righty = 180;
  //int leftx = 160, lefty = 60,rightx = 320,righty = 180;
  image.ImageWidth = rightx - leftx;
  image.ImageHeight = righty - lefty;  
  
          
  if(image.ImageWidth < 0 || image.ImageHeight < 0) errorLED();
  if(image.ColorSpace == binary && image.ImageWidth * image.ImageHeight > 19200) errorLED();
          
	  Image_Init(&image);     // initialize image structure
          
      if(image.ColorSpace == binary)
	    errorFlag = ImgCmd('R', leftx, lefty, rightx-1, righty-1, &image); //send commond to camera and get image
      else
        errorFlag = ImgCmd('G', leftx, lefty, rightx-1, righty-1, &image);
          
      if(errorFlag!=0)
     {
           Delete_Image(&image);   //clear image data buffer
           break; // The pixels error, commond don't transmit.
     }         
          
       Send_Image_toMem(&image);
	   if(Check_Data()=1)
       Delete_Image(&image);   //clear image data buffer       
       else Send_Image_toMem(&image);

  
}

int ImgCmd(char c, int Lx, int Ly, int Rx, int Ry, Image_Profile_TypeDef* Img)
{
    uint8_t rxHex[2], ryHex[2], lxHex[2], lyHex[2];
    int pixCnt, width, height;
    
    if(Rx <= Lx || Ry <= Ly || 
        Lx < 0 || Lx >= 320 ||
        Ly < 0 || Ly >= 240 ||
        Rx < 0 || Rx >= 320 ||
        Ry < 0 || Ry >= 240)
    {
        return 1;   //over range
    }
    
    width = Rx - Lx + 1;
    height = Ry - Ly + 1;
    
    /* Color Space */
    switch (Img->ColorSpace)
    {
        case RGB24:
            pixCnt = width*height*3+1;
            break;
        case GrayScale:
            pixCnt = width*height+1;
            break;
        default:
            break;
    }   
    
    lxHex[0] = Lx & 0xff;
    lxHex[1] = (Lx >> 8) & 0xff;
    
    lyHex[0] = Ly & 0xff;
    lyHex[1] = (Ly >> 8) & 0xff;
    
    rxHex[0] = Rx & 0xff;
    rxHex[1] = (Rx >> 8) & 0xff;
    
    ryHex[0] = Ry & 0xff;
    ryHex[1] = (Ry >> 8) & 0xff;
    
    cam.printf("%c", c);
    cam.printf("%c", lxHex[0]);
    cam.printf("%c", lxHex[1]);
    cam.printf("%c", lyHex[0]);
    cam.printf("%c", lyHex[1]);
    cam.printf("%c", rxHex[0]);
    cam.printf("%c", rxHex[1]);
    cam.printf("%c", ryHex[0]);
    cam.printf("%c", ryHex[1]);  
    cam.putc(0);    
    myled = 1;    
    
    //cam.gets((char *)image.ImageData, pixCnt);    //receive data from camera
    for(int i = 0; i < pixCnt; i++)
        Img->ImageData[i] = cam.getc();
    myled = 0;

    return 0;
}


int Send_Image_toMem(Image_Profile_TypeDef* ImgProfile,int pixct)
{
    uint8_t width[2], height[2];
	uint32_t i = 0, shift = 0x00000008;
    uint8_t* ImgFormat;
    int idx;
    unsigned int PixCnt;    
    char timeoutFlag = 0;
    /* Rx and Tx buffers */
    SDRAM_GPIOConfig();
	MAX10_Asyn_PSRAM_Init()
    
    // transform int to unsigned char
    width[0] = ImgProfile->ImageWidth & 0xff;
    width[1] = (ImgProfile->ImageWidth >> 8) & 0xff;
    
    height[0] = ImgProfile->ImageHeight & 0xff;
    height[1] = (ImgProfile->ImageHeight >> 8) & 0xff;
    // end of transform int to unsigned char

    // trasmit format, width, height.
    /* Color Space */
    switch (ImgProfile->ColorSpace)
    {
        case RGB24:
            ImgFormat = (uint8_t*)"RGB888";
            PixCnt = ImgProfile->ImageWidth*ImgProfile->ImageHeight*3;
            break;
        case GrayScale:
            ImgFormat = (uint8_t*)"GSCALE";
            PixCnt = ImgProfile->ImageWidth*ImgProfile->ImageHeight;
            break;
        default:
            break;
    }   
	pixct=PixCnt;
    for(idx=0; idx<6; idx++) 
	{
	*(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=ImgFormat[idx];
		i = i + shift;
	}
	
    *(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=width[1];
		i = i + shift;
    *(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=width[0];
		i = i + shift;
    //pc.printf("%u", width[1]);
    //pc.printf("%x", width[0]);
    *(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=height[1];
		i = i + shift;
    *(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=height[0];
		i = i + shift;

    //pc.printf("%x", height[1]);
    //pc.printf("%x", height[0]);
    // end of trasmit format, width, height.
    
    timer.reset();
    timer.start();

    /* Loop until the USART1 Receive Data Register is not empty */
      
   /* for (idx=0;idx<PixCnt;idx+=3)
    {
       ImgProfile->ImageData[idx] = 0;
       ImgProfile->ImageData[idx+1] = 255;
       ImgProfile->ImageData[idx+2] = 0;
    }  */    
      
    for (idx=0;idx<PixCnt;idx+=1)
    {   
       *(__IO uint32_t *) (MAX10_SRAM_BANK_ADDR + i)=ImgProfile->ImageData[idx];
		i = i + shift;
		if(i>0x00ffffff){i=0;}
  
    }    
    
    timer.stop();
    return 0;    
}


