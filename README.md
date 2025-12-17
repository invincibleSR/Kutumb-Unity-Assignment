# Unity Developer Assignment – Kutumb / Primetrace Technologies

## Overview
This project is a small Unity demo created as part of the Unity Developer assignment.

It demonstrates:
- Real Google Sign-In authentication
- A humanoid character reacting with facial expressions
- Dialogue playback with basic lip-sync
- A fixed facial reaction sequence: Happy → Sad → Happy → Sad

The focus of this submission is correctness, stability, and clarity within the given time constraints.

---

## Authentication (Important)
This project uses **real Google Sign-In** implemented via **Firebase Authentication (OAuth)**.

### Notes:
- Google Sign-In **does not work in the Unity Editor or on PC builds**.
- The authentication flow works only on **Android devices**.
- For this reason, a **built APK is attached** along with this submission to allow direct testing.

### How it works:
1. User taps **Sign in with Google**
2. Google account chooser appears
3. On successful authentication, user details are fetched
4. The app automatically transitions to the Character Scene

---

## Facial Animation & Dialogue
- The humanoid character uses **bone-based facial animation** (jaw, lips, eyebrows).
- Dialogue audio plays during the reaction sequence.
- Basic lip-sync is achieved through jaw movement.
- Facial expressions (**Smile / Sad**) are implemented using **keyframed animation**.

### Implementation Note
I initially planned to drive the reaction sequence using coroutines for finer runtime control.  
However, due to the limited time window, I finalized the facial reactions as a **fully keyframed animation**, embedding the Smile and Sad expressions directly into the talking animation clip.  
This ensured stable, readable facial expressions while still meeting the assignment requirements.

The setup can be extended to a coroutine-driven or layered animation approach if needed.

---

## Reaction Sequence
The reaction sequence follows this exact order:

- Triggered by a single button press
- Dialogue and facial expressions play simultaneously
- Additional button presses are ignored while the sequence is running

---

## Scenes
- **LoginScene**
  - Google Sign-In button
  - Displays user name, email, and profile picture on successful login

- **CharacterScene**
  - Humanoid character
  - Reaction animation with dialogue and facial expressions

---

## Project Structure

Unity-generated folders (Library, Temp, Build, etc.) are intentionally excluded.

---

## How to Run
### Option 1 – Recommended
- Install the provided **APK** on an Android device
- Launch the app
- Sign in using a Google account

### Option 2 – Unity
- Open the project in Unity
- Note: Google Sign-In will **not function in the Editor**
- Character scene and animations can still be reviewed

---

## Unity Version
- Unity 2022 LTS (or compatible version)

---

## Final Notes
This submission prioritizes:
- Real authentication (no mock logic)
- Clear facial expressions and dialogue sync
- Clean project structure
- Practical trade-offs to deliver a complete, working demo within time constraints

Thank you for reviewing this assignment.
