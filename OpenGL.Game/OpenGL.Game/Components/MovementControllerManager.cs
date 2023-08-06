using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenGL.Game.Components
{
    public class MovementControllerManager : Component
    {
        public static MovementControllerManager Instance {get; private set;}

        private int currentlySelectedMovementControllerIndex = 0;
        private MovementController currentlySelectedMovementController;

        private List<MovementController> allMovementControllers = new List<MovementController>();

        //Since this class has a  method that subscribes to an event in the constructor, we make sure we only subscribe to this event once.
        private bool alreadySubscribedToStaticMethods = false;

        public MovementControllerManager(GameObject gameObject) : base(gameObject)
        {
            Instance = this;
            InputHelper.ButtonSpacePressedEvent += SelectNextMovementController;
        }

        public void MakeControllerActive(MovementController controller)
        {
            //Disable the previously selected controller
            currentlySelectedMovementController.MovementEnabled = false;
            currentlySelectedMovementController.RotationEnabled = false;

            //Set the controller as selected
            currentlySelectedMovementController = controller;
            currentlySelectedMovementControllerIndex = allMovementControllers.IndexOf(controller);

            //Activate the controller
            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }

        public override void OnUpdate()
        {
        }

        /// <summary>
        /// This method increments the currentlySelectedMovementControllerIndex by 1, selects and makes the next MovementController in the allMovementControllers List active.
        /// </summary>
        /// <param name="isPressed"></param>
        public void SelectNextMovementController(bool isPressed)
        {
            if (!isPressed) return;

            currentlySelectedMovementController.MovementEnabled = false;
            currentlySelectedMovementController.RotationEnabled = false;
            currentlySelectedMovementControllerIndex++;
            currentlySelectedMovementController = allMovementControllers[currentlySelectedMovementControllerIndex % allMovementControllers.Count];
            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }

        private void ChangeUITextToSelectedController()
        {
            if (!gameObject.game.UserInterfaceHelper.IsUIInitalized) return;

            gameObject.game.UserInterfaceHelper.currentlySelectedText.String = currentlySelectedMovementController.GameObject.Name;
        }

        public void AddMovementController(MovementController controller)
        {
            allMovementControllers.Add(controller);

            if (currentlySelectedMovementController != null)
            {
                currentlySelectedMovementController.MovementEnabled = false;
                currentlySelectedMovementController.RotationEnabled = false;
            }

            currentlySelectedMovementController = controller;
            currentlySelectedMovementControllerIndex = allMovementControllers.IndexOf(controller);

            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }
    }
}