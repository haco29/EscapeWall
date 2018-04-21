#define LED 13

// Using http://slides.justen.eng.br/python-e-arduino as refference

int redLEDPin=9; //Declare redLEDPin an int, and set to pin 9 
int yellowLEDPin=10; //Declare yellowLEDPin an int, and set to pin 10 
int yellowOnTime=250; //Declare yellowOnTime an int, and set to 250
int yellowOffTime=250; //Declare yellowOffTime an int, and set to 250

void setup() {
    pinMode(redLEDPin, OUTPUT);
    Serial.begin(9600);
}

void loop() {
    if (Serial.available()) {
        char serialListener = Serial.read();
        if (serialListener == 'H') {
            digitalWrite(redLEDPin, HIGH);
        }
        else if (serialListener == 'L') {
            digitalWrite(redLEDPin, LOW);
        }
    }

  //digitalWrite(yellowLEDPin,HIGH); //Turn yellow LED on
  //delay(yellowOnTime); //Leave on for yellowOnTime
  //digitalWrite(yellowLEDPin,LOW); //Turn yellow LED off
  //delay(yellowOffTime); //Leave off for yellowOffTime
}
