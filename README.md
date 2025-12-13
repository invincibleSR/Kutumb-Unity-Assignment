# Kutumb-Unity-Assignment

## Overview
This project is a small Unity demo created as part of the Kutumb Unity Developer assignment.

It includes:
- A simple login scene with password validation
- A humanoid character scene
- A facial reaction sequence (Smile → Sad → Smile → Sad)
- Dialogue playback with basic jaw-based lip-sync

## Scenes
- LoginScene  
  - Password input (valid password: 1234)
  - Shows "Invalid login" on incorrect input

- CharacterScene  
  - Humanoid character
  - Play Reaction button
  - Facial expressions triggered via Animator
  - Audio dialogue with jaw bone lip-sync

## Technical Notes
- Facial expressions are implemented using keyframed facial bones
- Jaw movement is driven by script during dialogue playback
- Animator uses separate layers for facial expressions and talking
- External APIs were intentionally avoided as per assignment scope

## How to Run
1. Open the project in Unity
2. Open LoginScene
3. Press Play
4. Enter password: 1234
5. Click "Play Reaction" in the character scene

## Unity Version
Unity 2022 LTS (or your version)

