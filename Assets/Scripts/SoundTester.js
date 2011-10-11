#pragma strict

function Update() {
    for (var touch in Input.touches) {
        if (touch.phase == TouchPhase.Began) {
            audio.Play();
            break;
        }
    }
}
