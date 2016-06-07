int main(void)
{
 while(1)
{
grafcet3();
}
}

void grafcet3(void)
{
if(x30==1){x31==1;x30==0;}
else if(x31==0){x32==1;x31==0;}
else if(x32==0){x30==1;x32==0;}
action3();
}
void action3(void)
{
if(x30==1)formating();
else if(x31==1)ocr();
else if(x32==1)output();
}

