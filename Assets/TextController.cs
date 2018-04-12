using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text text;
    enum States { instructions, darkness, exist, nothing_found, flashlight, to_be, eternity, pit0, pit1,ledge0, shackles, pit_chain, chain, ledge1, hook, climb, fire, path_outside, path_cat, cat, lights, admire, reply, breathe, lie, up};
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.instructions;
    }

    // Update is called once per frame
    void Update()
    {
        //print(myState);
        if (myState == States.instructions) { instructions(); }
        else if (myState == States.darkness) { darkness(); }
        else if (myState == States.exist) { exist(); }
        else if (myState == States.nothing_found) { nothing_found(); }
        else if (myState == States.flashlight) { flashlight(); }
        else if (myState == States.to_be) { to_be(); }
        else if (myState == States.eternity) { eternity(); }
        else if (myState == States.pit0) { pit0(); }
        else if (myState == States.pit1) { pit1(); }
        else if (myState == States.ledge0) { ledge0(); }
        else if (myState == States.shackles) { shackles(); }
        else if (myState == States.pit_chain) { pit_chain(); }
        else if (myState == States.chain) { chain(); }
        else if (myState == States.ledge1) { ledge1(); }
        else if (myState == States.hook) { hook(); }
        else if (myState == States.climb) { climb(); }
        else if (myState == States.fire) { fire(); }
        else if (myState == States.path_outside) { path_outside(); }
        else if (myState == States.path_cat) { path_cat(); }
        else if (myState == States.lights) { lights(); }
        else if (myState == States.admire) { admire(); }
        else if (myState == States.reply) { reply(); }
        else if (myState == States.breathe) { breathe(); }
        else if (myState == States.lie) { lie(); }
        else if (myState == States.up) { up(); }
    }
    #region State handler methods

    void instructions()
    {
        text.text =
            "Welcome to From Darkness - A Text Adventure!\n" +
            "By @stewartjmartin - productivegaming.com \n\n" +

            "Use your keyboard to make selections.  There are three endings.  " +
            "See if you can find them all.  Fullscreen is recommended.\n\n"+
            "Please press \"K\" on your keyboard to continue";

        if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.darkness;

        }
    }

    void darkness()
    {
        text.text =
            "You find yourself in darkness, with no memory of the past.\n\n" +
            "Press E to make sure you Exist.";
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.exist;

        }
    }

    void exist()
    {
        text.text =
            "You pat yourself down and find you have a physical body, " +
            "and are lying on dirt and rocks.  Your eyes are open, " +
            "but you can see nothing. \n\n" +
            "Press S to Search. Press E to contemplate Existence.";
        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.darkness;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.nothing_found;

        }
    }

    void nothing_found()
    {
        text.text =
            "You search but find nothing but dirt and stones. \n\n" +
            "Press S to keep Searching.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.flashlight;

        }
    }

    void flashlight()
    {
        text.text =
            "Your persistence pays off and your hand falls upon a flashlight.  " +
            "You fumble with the flashlight, in the dark, and eventually " +
            "find the lever that should turn it on.  You hope that it works.\n\n " +
            "Press T to Turn on the flashlight. Press E to contemplate Existence.";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.pit0;

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.to_be;

        }
    }

    void to_be()
    {
        text.text =
            "Until now, the darkness has been like a warm embrace.  " +
            "Now that you have the power to banish it, the possibilities of " +
            "what lies within cripples you with anxiety and doubt.\n\n " +
            "Press T to Turn on the flashlight. Press D to remain in Darkness.";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.pit0;

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.eternity;

        }
    }

    void eternity()
    {
        text.text =
            "You remain, safe and sound in your shell of darkness, for eternity.\n\n " +
            "Press P to Play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.darkness;

        }
    }

    void pit0()
    {
        text.text =
            "You turn on the flashlight, and squint as your eyes adjust. Dark shapes dance " +
            "as you move your flashlight. You pick yourself up off the ground and find " +
            "you are in a dank, cavernous pit.\n\n" +
            "Press P to examine the Pit.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.pit1;

        }

    }

    void pit1()
    {
        text.text =
            "You are surrounded by high reaching walls with a stalactite ceiling.  " +
            "A few stalagmites protrude from the dirt floor.  Shadows, cast by  " +
            "your flashlight, crawl along the walls.  You see a ledge out of reach" +
            " on one side, and some chains and shackles attached to the same wall.\n\n" +
            "Press L to examine the Ledge.  Press S to examine the Shackles.";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.ledge0;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.shackles;

        }
    }

    void ledge0()
    {
        text.text =
            "A stalagmite near the edge looks like a good place to hook something, " +
            "If you only had something to hook to it. \n\n" +
            "Press R to return to pit.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.pit1;

        }
    }

    void shackles()
    {
        text.text =
            "The shackles appear to have been designed to keep people pinned against the wall, " +
            "facing forward.  One of the chains appears to be loose. \n\n" +
            "Press P to Pull the chain.  Press R to Return to pit.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.pit_chain;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.pit1;

        }
    }

    void pit_chain()
    {
        text.text =
            "You pull the chain and it refuses to come loose.  " +
            "You yank the chain harder and it finally releases from the wall " +
            "as you tumble to the floor. \n\n" +
            "Press L to examine the Ledge. Press C to wear the Chain.";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.ledge1;

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.chain;

        }
    }

    void chain()
    {
        text.text =
            "You feel a little silly wearing the large, heavy chain, in a dank pit. " +
            "No judgement here. \n\n" +
            "Press L to examine the Ledge.";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.ledge1;

        }
    }

    void ledge1()
    {
        text.text =
            "You cannot reach the ledge, but it appears to be the only way out of here.  " +
            "A stalagmite near the edge looks like a good place to hook something. \n\n" +
            "Press H to Hook the stalagmite with the chain.  ";
        if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.hook;

        }
    }

    void hook()
    {
        text.text =
            "After many tries you finally hook the chain on the stalagmite and test that it will hold fast. " +
            "It appears to be sturdy enough to climb. \n\n" +
            "Press C to Climb";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.climb;

        }
    }

    void climb()
    {
        text.text =
            "You grip the chain tightly, and push off the wall with your feet. " +
            "It takes the last of your strength to drag your fleshy body up  " +
            "on to the ledge and you lie there trying to catch your breath. \n\n" +
            "Press U to get Up and examine your surroundings.";
        if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.fire;

        }

    }

    void fire()
    {
        text.text =
            "On the ledge, there is a cold fire pit, and a well worn path that leads down corridors to your left  " +
            "and to your right. " +
            " \n\n" +
            "Press L to take the Left path.  Press R to take the Right path.";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.path_outside;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.path_cat;

        }
    }
    void path_outside()
    {
        text.text =
            "As your progress down the corridor you begin to see a white light filtering through. " +
            "You squint more and more as  you get closer.  As you emerge out into the open, " +
            "the light is unbearably bright, and you feel the pain deep in your bones. \n\n" +
            "Press R to Retreat back to the darkness.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.fire;

        }

    }
    void path_cat()
    {
        text.text =
            "At the end of the corridor, you see a grey domestic cat with vibrant, green, eyes.\n" +
            "He seems familiar.\n" +
            "His shadow creeps up the back wall of the cavern, like a monstrous beast. \n\n" +
            "Press A to Approach cat.  Press F to return to Fire pit.";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.lights;

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.fire;

        }
    }

    void lights()
    {
        text.text =
            "As you approach the feline, the light from your flashlight begins to warp and the light rays " +
            "begin to change colors as if from a colored glass window, or a kaleidoscope.  " +
            "The colored shapes dance around in a mesmerizing pattern. \n\n" +
            "Press A to Admire the light show.";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.admire;

        }
    }

    void admire()
    {
        text.text =
            "You tune in, and watch in wonderment.\n" +
            "Suddenly, your attention is grabbed by the cat.\n" +
            "You can hear him speak, though his mouth doesn’t move.\n" +
            "\"Our time is short.  Know this; out of desperation, your enemy causes you to suffer in " +
            "an attempt to prevent your success.  Succeed in spite of your suffering, " +
            "and your enemies suffering will be ten times greater.\" \n\n" +
            "Press R to Reply.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.reply;

        }

    }

    void reply()
    {
        text.text =
            "As you attempt to reply, you can only make muffled noises. " +
            "The world burns away like film stuck in an antique projector. \n\n" +
            "Press B to breathe deeply";
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.breathe;

        }

    }

    void breathe()
    {
        text.text =
            "As you exhale, you hear birds from afar and you see sun light from behind closed eyelids.  " +
            "You taste morning breath, and you feel your warm bed enveloping you.  " +
            "You open your eyes and check the time.  " +
            "You have an hour and a half before your important appointment. \n\n" +
            "Press G to get up.  Press L to lie in bed.";
        if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.up;

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lie;

        }
    }

    void lie()
    {
        text.text =
            "You lay in bed for a while and drift back into a dreamless sleep.  You miss your appointment,  " +
            "and cannot reschedule.  \n\n" +
            "Thanks for playing!  Press P to play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.darkness;

        }
    }

    void up()
    {
        text.text =
            "You get up feeling determined, and diligently get ready for your day.  " +
            "You arrive at your appointment fifteen minutes early, and the future looks promising.  \n\n" +
            "Thanks for playing!  Press P to play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.darkness;

        }
    }

    
    #endregion
}
