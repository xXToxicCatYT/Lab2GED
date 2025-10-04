# Lab2GED

Name: Edmond Huang

Student #: 100923160

Cube Guess: A simple guessing game with 4 cubes that spawn when the game starts. The goal is to pick all the safe cubes without the bomb.

Pseudocode for Factory:

CLASS CubeFactory

    FUNCTION CreateCube(safeCube, bombCube, position, isBomb)
        IF isBomb THEN
            choose bombCube
        ELSE
            choose safeCube
        ENDIF
        create cube at position
        RETURN cube
    END FUNCTION
    
END CLASS

CLASS CubeSpawner

    SET starting position = (-4, 0)

    FUNCTION Start()
        pick random number from 0 to 3 → bombIndex

        FOR i = 0 TO 3
            IF i equals bombIndex THEN
                isBomb = TRUE
            ELSE
                isBomb = FALSE
            ENDIF

            position = starting position shifted by (i * 2, 0)
            CALL CubeFactory.CreateCube(safeCube, bombCube, position, isBomb)
        END FOR
    END FUNCTION
    
END CLASS

The factory used can create 2 different types of cubes.

The factory pattern is a great choice for this because it picks which cube prefab to create without duplicating code.
