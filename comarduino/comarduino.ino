
int i=0;
String data ="";
boolean stringComplete = false;
void setup() {
 
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  Serial.begin(9600);
}

void loop() {
  //Serial.println(i);
  if (data=="on"){
  digitalWrite(LED_BUILTIN, HIGH); 
  }else if (data =="off"){
  digitalWrite(LED_BUILTIN, LOW);
  }
  
  Serial.println(i);
  
  i=i+1;  
  delay(1000);
  if(i>20) i=0;
}
void serialEvent(){
  data="";
  while(Serial.available()){
    char inChar = (char)Serial.read();
    data += inChar;
    if(inChar == '\n'){
      stringComplete = true;
    }
  }
}
