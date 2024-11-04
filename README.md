This is Strategy sample 

You can always use virtual methods and override them

![image](https://github.com/user-attachments/assets/6e434218-17ef-4727-99d3-c54ae91ded11)
![image](https://github.com/user-attachments/assets/c61df604-e8f0-4b69-9d9a-3d04b369f272)


but if your class can perform many actions and there are many possible combinations of these actions, you will end up with too much code

Instead in place of implementation, you need to program at the interface level
1) Separate permanent parts from changeable parts
2) create interfaces for changeable parts
   
![image](https://github.com/user-attachments/assets/9eb953b2-53ad-4033-9563-c2ddb9cd3e2a)
![image](https://github.com/user-attachments/assets/bf622d4e-129a-4ee8-8fca-a88847a5ddaf)


3) Create fields to implement these interfaces

![image](https://github.com/user-attachments/assets/10d23640-e7cf-4455-b4b3-6cc702b5e88c)

and classes that will define the capabilities of the interfaces

![image](https://github.com/user-attachments/assets/8606fab3-d37d-4ff7-a916-908dfae72ae0)
![image](https://github.com/user-attachments/assets/0e2d4e71-255d-4842-987f-410196fcb596)

4) Create an abstract class constructor that will define behaviour

![image](https://github.com/user-attachments/assets/ae614f11-a10e-448a-a3f7-c4cd163a1827)

Methods to set new values

![image](https://github.com/user-attachments/assets/a0df93ad-25b8-4d00-a552-489b08a2107d)

And Methods to perform actions

![image](https://github.com/user-attachments/assets/ac7c8671-a964-496d-936d-4d978c0aa338)

5) In descendant classes, also specify behavior through the constructor if necessary

![image](https://github.com/user-attachments/assets/0e89fb7b-8ca5-44e1-a51d-3aa281efdd41)

This is all(imo), i hope this will help you!
