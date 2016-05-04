# Embeding-System-Design-Final-Project
Embeding System Design Final Project

Project Theme:
==============================================
	Cut Bill & Word Recognition Automata

Requirement:
=============================================
	本系統對拍攝的票據影像做影像處理和OCR 辨識出票據文字 并將文字資料formating傳送至雲端 實現銀行票據的資料自動錄入

Scenarios:
=============================================
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

Exceptional scenarios:
=============================================
	case 1:
		aS takes a invalid photo
		aUI print error info

	case 2:
		User input a valid operate
		aUI print error info

Acceptance Test Cases:
=============================================
	case 1:

	case 2:

	case 3:

User’s Manual:
=============================================
	本成績系統配有一個camera用於拍攝影像

	兩個button 用於電源開關和啟動拍攝

	一個LCD屏 用於顯示當前狀態

	一個UART用於與PC連接

	一個MCU(STM32F429)用於system control

	一個FPGA用於image process&recognition

	一個Flash用於image buffer

	protocol為串口通信

	data format為JSON

	PC端配有一個demo軟體


	使用者按下電源開關(btn1) 系統啟動 準備完畢後LCD會顯示歡迎介面

	使用者按下啟動拍攝開關(btn2) camera拍下當前影像 裁剪出影像的票據 如果成功裁剪出票據LCD會顯示成功介面

	同時UART開始向PC傳輸影像和票據資料

	系統可處理兩種異常 1) 輸入錯誤影像 2) 輸入不正確指令

Architectural Design:
=============================================
Module cut:
=============================================
	DSP module：
	NUCLEO-F446RE
		Implement Function：Image process、State Machine

	FPGA module:

		Implement Function：Image Control

	Sensor module:

	communicate module:

	 	UART連線
	 	
	 	使用JSON格式傳輸資料

	Memory module:


Detailed Design (design sketch and pseudo-code):
=============================================
	data structure:

	algorithm:

Examples of Unit Test Code:
=============================================
A Real Input Image:
=============================================
