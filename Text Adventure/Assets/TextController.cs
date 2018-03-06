using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    private enum Scenes {start, initial, dodge, attack, backstab, party, check_thark, attention, dodge_L, dodge_R, lure, dodge_rage, hide, gameover_retreat, tend, Crit_tend, Ok_tend, Fail_tend, CritFail_tend, };
    private Scenes PresScene;
    int TendTime = Random.Range(0, 10);
    // Use this for initialization
    void Start () {
        PresScene = Scenes.start;
        
	}

    // Update is called once per frame
    void Update () {
        //Restart Hotkey for Dev Purposes. REMOVE WHEN DONE CODING!
        if (Input.GetKey(KeyCode.F1)) 
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                PresScene = Scenes.start;
            }
        }
        //Scene Swapping
            if (PresScene == Scenes.start)
        {
            Scene_start();
        }
        

        if (PresScene == Scenes.initial)
        {
            Scene_initial();
        }
        else if (PresScene == Scenes.dodge)
        {
            Scene_dodge();
        }
        else if (PresScene == Scenes.backstab)
        {
            Scene_backstab();
        }
        else if (PresScene == Scenes.dodge_L)
        {
            Scene_dodge_L();
        }
        else if (PresScene == Scenes.dodge_R)
        {
            Scene_dodge_R();
        }
        else if (PresScene == Scenes.attention)
        {
            Scene_attention();
        }
        else if (PresScene == Scenes.dodge_rage)
        {
            Scene_dodge_rage();
        }
        else if (PresScene == Scenes.lure)
        {
            Scene_lure();
        }
        else if (PresScene == Scenes.hide)
        {
            Scene_hide();
        }
        else if (PresScene == Scenes.tend)
        {
            Scene_tend();
        }
    }
    void Scene_start()
    {
        text.text = "Welcome to Mythras, a text adventure game. Your Party consists of you, the Rogue; Thark, the Barbarian; Yondor, the Paladin; " +
              "Rook, the Hunter; Shior, the Sorceress; Greihardt, the Cleric; and Shru'in, the Druid. Please press Space to begin";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PresScene = Scenes.initial;
        }
    }
    void Scene_initial ()
    {
        text.text = "You enter the Fortress with Thrak, Yondor, and Shior. You leave the others to be lookouts at the entrance. You have been preparing for this quest for weeks." + 
            "Training, getting better weapons and armor," +
            " recruiting a few new members, scouting the fortress, gathering information, and most importantly, having a grand time at the tavern. Now you're finally here" +
            "and so you start your ascent to the tower, but you're stopped by a heavily armored Orc who seems to not have any inention of letting you pass. " +
            "As if to confirm that suspicion, he lets out a guttural roar as he charges at the party. What do you do? Press D to dodge, A to attack, C to counter. ";
        if (Input.GetKeyDown(KeyCode.D))
        {
            PresScene = Scenes.dodge;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            PresScene = Scenes.attack;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            PresScene = Scenes.backstab;
        }
    

    }
    void Scene_dodge ()
    {
        text.text = "You attempt to dogde the charging Orc, and he just barely misses you. A split second later, and you would have a broken leg or two. You look back to " +
            "check on the rest of the party, and as you look back, you see Thark, the Barbarian, get hit nearly dead on by the charging Orc, knocking him back to the entry hall " +
            "you just exited. It seems the rest of the party is unhurt, but Yondor, the Paladin, has a dent in her shield from the Orc flailing around. What's your next " +
            "course of action? B to backstab the Orc, A to bring attention to yourself, C to check on Thark."
            ;
        if (Input.GetKeyDown(KeyCode.B))
        {
            PresScene = Scenes.backstab;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PresScene = Scenes.attention;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PresScene = Scenes.check_thark;
        }
    }
    void Scene_backstab ()
    {
        text.text = "You roll behind the Orc and attempt to backstab him, but it does very little, as your dagger clanks off the heavy armor the Orc is wearing. He turns " +
            "around to face you, and then proceeds to start an overhead smash, but it seems different somehow. You don't have to think though, so you write it off, ready " +
            "to act. What do you do? L to dodge left, R to dodge right";
        if (Input.GetKeyDown(KeyCode.L))
        {
            PresScene = Scenes.dodge_L;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            PresScene = Scenes.dodge_R;
        }
    }
    void Scene_dodge_L ()
    {
        text.text = "As you dodge, the Orc suddenly changes to a diagonal swing and he misses you, but just barely. You quickly get on your feet, and the Orc decides to " +
            "Go after Yondor, your Paladin, who has started to charge the Orc, with Shior behind her, ready to attack. What do you do? S to stand by, C to check on Thrak.";
    }
    void Scene_dodge_R ()
    {
        text.text = "As you dodge, the Orc suddenly changes to a diagonal swing and he hits you square in the side. You hear a sickening crunch and feel a sharp pain in" +
            " your side as the club makes contact with your side. You're knocked unconscious as you slam against the wall, shooting pain up your injured side. W to wait." ;
    }

    //end of backstab tree

    //start of attention tree
    void Scene_attention()
    {
        text.text = "You yell insults at the Orc, and it seems your plan works. He turns around with blinding speed, speed you thought impossible for an Orc to achieve and" +
            " he roars at you, and proceeds to go into a blind rage, not caring what he hits. You can use this to your advantage if you execute it right. L to lure the Orc" +
            " into a pillar, D to dodge the Orc, and H to hide.";
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            PresScene = Scenes.lure;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            PresScene = Scenes.dodge_rage;
        }
        else if(Input.GetKeyDown(KeyCode.H))
        {
            PresScene = Scenes.hide;
        }
    }
    void Scene_lure()
    {
        text.text = "You attempt to lure the Orc into a pillar, and he follows you without any thought. As he wildly swings at you while you stay just out of reach, he hits " +
            "a pillar, and it comes crashing down on him, killing him instantly. 'Your armor won't protect you from that!' you taunt to the now dead Orc. P to proceed.";
    }
    void Scene_dodge_rage()
    {
        text.text = "You start to dodge the Orc's furied swings and as you go on, you know you can't keep going much longer. What do you do? P to call on your party, C to " +
            "continue, H to hide.";
    }
    void Scene_hide()
    {
        text.text = "You quickly hide behind the nearest pillar, and luckily, the Orc didn't see you. However, he has to take his rage out on someone, so he turns to Yondor. " +
            "He proceeds to start battering her shield, and Shior starts casting a spell behind Yondor. She releases it, and you think it normally would've killed the Orc, " +
            "but he instead shakes it off, even as he's bleeding and surely has even more blurred vision from the blow. Yondor can't hold her shield up much longer, but" +
            "you're too far away to do anything, so you watch in horror as the Orc deals a blow to Yondor, knocking her unconcious, and smashes Shior's head in, killing her." +
            "you decide to call to the other party members who were outside as lookouts to come help carry the two unconcious members out, and you retreat. P to proceed.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            PresScene = Scenes.gameover_retreat;
        }
    }

    //end of attention tree

    //start of Game Over tree
    void Scene_gameover_retreat()
    {
        text.text = "You chose poorly and your party was in too bad of shape to continue. You consequently had to retreat, so your game is over. Press R to restart";
        if (Input.GetKeyDown(KeyCode.R))
        {
            PresScene = Scenes.initial;  
        }
    }

    //start of check tree
    void Scene_check()
    {
        text.text = "You rush over to check on Thark, and you begin to check for any wounds. He seems to have a fractured rib, and his right arm is broken, but other " +
            "than that, he only sustained minor bruising and some scrapes. You think you can tend to his wounds, but it'll only be a minor fix, just enough to get him to "+
            "Greihardt, the Cleric. You'll need some backup though, so that the Orc doesn't crush you. What will you do? T to tend to his wounds, H to go back to hiding"; 
        if (Input.GetKeyDown(KeyCode.T))
        {
            PresScene = Scenes.tend;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            PresScene = Scenes.hide;
        }

        
    }
    void Scene_tend()
    {
        text.text = "You ask Shior and Yondor to cover you, and they take the Orc's attention. You start to tend to Thark's wounds, but you know it will take some time. " +
            "Press C to continue.";
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (TendTime >= 8)
            {
                PresScene = Scenes.Crit_tend;
            }
            if (TendTime <= 7 && TendTime >= 5 )
            {
                PresScene = Scenes.Ok_tend;
            }
            if (TendTime <= 4 && TendTime > 1)
            {
                PresScene = Scenes.Fail_tend;
            }
            if (TendTime == 1)
            {
                PresScene = Scenes.CritFail_tend;
            }
        }
    }
    void Scene_CritTend()
    {
        text.text = "You speedily and accurately tend to Thark's wounds. He then gets up, charges at the distracted Orc, and beats him to death. You Win! R to Restart.";
        if (Input.GetKeyDown(KeyCode.R))
        {

        }
    }
    void Scene_OkTend()
    {
        text.text = "You speedily tend to Thark's wounds, it's not perfect, but it's enough. You currently have one clear option. What will you do? A for an All-Out Attack" +
            " , R to Retreat.";

    }
}
