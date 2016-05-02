# Embeding-System-Design-Final-Project
Embeding System Design Final Project

Project Theme:

	Cut Bill & Word Recognition Automata

Requirement:

	本系统实现银行票据的资料自动录入

Scenarios:

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

	case 1:
		aS takes a invalid photo
		aUI print error info

	case 2:
		User input a valid operate
		aUI print error info

Acceptance Test Cases:
	
	case 1:

	case 2:

	case 3:

User’s Manual:

本成績系統配有一个camera用于拍摄影像
两个button 用于电源开关和启动拍摄
一个LCD屏 用于显示当前状态
一个UART用于与PC连接
一个MCU(STM32F429)用于system control
一个FPGA用于image process&recognition
一个Flash用于image buffer
protocol为串口通信
data format为JSON
PC端配有一个demo软体

使用者按下电源开关(btn1) 系统启动 准备完毕后LCD会显示欢迎界面
使用者按下启动拍摄开关(btn2) camera拍下当前影像 裁剪出影像的票据 如果成功裁剪出票据LCD会显示成功界面 同时UART开始向PC传输影像和票据资料

系統可處理兩種異常 1) 輸入錯誤影像 2) 輸入不正確指令

Architectural Design:

Module cut:
	
	DSP module：
	NUCLEO-F446RE
		Implement Function：Image process、State Machine（MIAT：GRAFCET->State Machine Code -> Top-Down Design）

	FPGA module:

		Implement Function：Image Control

	Sensor module:

	communicate module:

	 	UART连线
	 	使用JSON格式传输资料

	Memory module:


Detailed Design (design sketch and pseudo-code):

	data structure:

	algorithm:

Examples of Unit Test Code:

A Real Input Image: