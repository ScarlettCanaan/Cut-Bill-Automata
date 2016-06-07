LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;
USE IEEE.STD_LOGIC_ARITH.ALL;
USE IEEE.STD_LOGIC_UNSIGNED.ALL;

entity EX is 
port(
  clk,rst:in std_logic;
 	clk,rst:in std_logic;
	Open_state: out std_logic;
	Cut_bill_system: out std_logic;
	Button: in std_logic;
	Camera_Button: in std_logic;

      );
end EX;

ARCHITECTURE controller OF EX IS
	signal X0,X1,X2: std_logic;
begin
grafcet1: process(clk,rst)
begin 
   if rst='0' then X0<='1'; X1<='0'; X2<='0'; 
   elsif clk'event and clk='1' then
      if X0=¡®1¡¯ and Button=¡®1¡¯ then X0<=¡®0¡¯; X1<=¡®1¡¯; X2<=¡®1¡¯; 
      elsif X1='1' and Camera_Button='1' then X1<='0'; X2<='1';
      elsif X2='1' and Button='1' then X2<='0';  X1<='1';
      elsif X2='1' and Button='0' then X2<='0';  X0<='1';
      end if;
   end if;
end process grafcet1;

datapath: process(clk)
begin 
	if clk'event and clk='1' then
		Open_State<=X1; 
		Cut-_Bill_System<=X2; 
	end if;
end process datapath;

end controller;




