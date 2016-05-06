
#Project Theme:

Cut Bill & Word Recognition Automata

#Requirement:

本系統對拍攝的票據影像做影像處理和OCR 辨識出票據文字 并將文字資料formating傳送至雲端 實現銀行票據的資料自動錄入

#Scenarios:

A user interface (aUI) : LCD
	
A sensor(aS) : camera

A data communication device(aCD)

A terminal(aT) : Button

	case 1:
	User start automata(aT be pressed)
	aUI showWelcomeMsg

	case 2:
	User eable cut bill(aT be pressed)
	aS takesPhoto
	aUI showSuccessMsg
	aCD sendImage&info

#Exceptional scenarios:

A sensor(aS) : camera

A user interface (aUI) : LCD

	case 1:
	aS takes a invalid photo
	aUI print error info

	case 2:
	User input a valid operate
	aUI print error info

#Acceptance Test Cases:

case 1:

case 2:

case 3:

#User’s Manual:

本成績系統配有一個camera用於拍攝影像

兩個button 用於電源開關和啟動拍攝

一個LCD屏 用於顯示當前狀態

一個UART用於PC terminal通信

一个WiFi module用於與PC terminal通信

一個MCU(STM32F429)用於system control

一個FPGA用於image preprocess&recognition

一個FSMC用於MCU與FPGA通信

MCU與PC terminal通信protocol為UART

data format為JSON

PC Terminal配有一個demo軟體


使用者按下電源開關(btn1) 系統啟動 準備完畢後LCD會顯示歡迎介面

使用者按下啟動拍攝開關(btn2) camera拍下當前影像 裁剪出影像的票據 如果成功裁剪出票據LCD會顯示成功介面

同時UART開始向PC傳輸影像和票據資料

系統可處理兩種異常 1) 輸入錯誤影像 2) 輸入不正確指令

#Architectural Design:

#Module Cut:

DSP module:

	MCU:NUCLEO-F446RE
	Implement Function：Image process\State Machine\OCR module

FPGA module:

	FPGA:MAX10 FPGA
	Implement Function：Image preprocessing of hardware accelerator

Sensor module:

	Smart Sensor:OV7725 smart sencor

communicate module:

	MCU-FPGA:FSMC
	MCU-terminal:UART
	MCU-terminal(Data Formating):JSON

#Detailed Design (design sketch and pseudo-code):

data structure:

algorithm:

	Image preprocessing:
		Image Denoising:median filtering
		Image Binaryzation:OSTU cvAdaptive Threshold
		Edge detetion:canny
		skewness:hough transform
		Image Cut:hough transform

#About:

This package contains an image processing and OCR engine and image recognition.

The lead developer and maintainer is Yan Ming. The helper is Yuqiao Tian.

For a list of contributors see [AUTHORS](https://github.com/ScarlettCanaan).

You should note that in many cases, in order to get better OCR results.

The latest stable version is 1.00.00, released in May 2016.

**NOTE**: This software/hardware maybe depends on other packages that may be licensed under different open source licenses,OCR module please see [Tesseract](https://github.com/tesseract-ocr/tesseract/) for more information
