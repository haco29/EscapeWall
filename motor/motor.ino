#include <AFMotor.h>
#include <Servo.h>

AF_DCMotor motor1(1);
AF_DCMotor motor2(2);
AF_DCMotor motor3(3);
AF_DCMotor motor4(4);
Servo servo1;

void setup() {
  motor1.setSpeed(255);
  motor2.setSpeed(255);
  motor3.setSpeed(255);
  motor4.setSpeed(255);
  servo1.attach(9);
  Serial.begin(9600);

}
void loop() {
  if (Serial.available()) {
    char serialListener = Serial.read();
    if (serialListener == 'H') {
      motor1.run(FORWARD);
      delay (1000);
      motor1.setSpeed (0);
    }
  }
  motor2.run(FORWARD);
  delay (1000);
  motor2.setSpeed (0);

  motor3.run(FORWARD);
  delay (1000);
  motor3.setSpeed (0);

  motor4.run(FORWARD);
  delay (1000);
  motor4.setSpeed (0);

  servo1.write(255);
  delay (1000);
  servo1.write(255);
}
