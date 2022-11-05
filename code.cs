// C++ code
//
byte tmp=A0;
byte led=2;
int A;
void setup()
{
  pinMode(tmp,INPUT);
  pinMode(2, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  A=analogRead(tmp);
  Serial.print("A=");
  Serial.println(A);
  digitalWrite(2,!A);
  if(A<50)
  {
  digitalWrite(2, HIGH);
  }
  else{
    
  digitalWrite(2, LOW);
  delay(1000); 
  }
}
