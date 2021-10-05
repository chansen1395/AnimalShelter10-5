Animal Shelter
Make a program for an animal shelter to track the animals in their facility based on animal type (such as cat or dog). Build out features that let a shelter worker:

Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
Add an animal to the system. An animal should have a name, gender, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
List animals by breed or type alphabetically.
List animals starting with the ones who have been in the shelter the longest.

TABLE: Animals
Col 1 AnimalId - int
Col 2 Type - Varchar(45) - dropdown for input
Col 3 Name - varchar
Col 4 Gender - varchar - dropdown for input
Col 5 DateAdmitted - DateTime
Col 6 Breed - varchar

public DateTime OrderDate { get; set; }
DateTime orderDate = rdr.GetDateTime(4);