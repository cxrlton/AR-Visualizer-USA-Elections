# AR Visualizer: USA-Elections  (SE20UARI116)
APP: AN AUGMENTED REALITY VISUALIZER OF THE 2020 USA ELECTIONS STATES MAP W/ GAZE INTERACTION OF STATES AND ELECTORAL VOTES


Application can be used on iOS devices using the XCode build, while connecting your iOS device of choice to your Mac (Here Iphone 14 Plus).


### Working:
- Here, one of the axes vector’s works (y-axis in this case) as the eyes or Raycast, which is a laser beam which triggers an event when it passes through a scene object. It then displays a Text Mesh display box containing the Name of the State, and its respective electoral vote count.
- InfoBehavior Script: Takes the “gaze” interactions and controls the display text. If the eyes are no longer focused on the object the text collapses into the object.
- FaceCamera Script: Orients the displayed text such that it always faces the camera, or the “eyes”. Tested by moving the AR Camera around the scene.
- Gaze Script: The main script which activates the Raycast event, allowing it to trigger the “Gaze Interaction” event when the raycast passes through an object which contains a certain label or tag. Here the tag given was “hasInfo”.
- Codes were all written in C#.

