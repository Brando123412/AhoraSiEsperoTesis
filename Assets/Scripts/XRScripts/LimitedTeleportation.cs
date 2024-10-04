using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.Interaction.Toolkit;
public class LimitedTeleportationProvider : TeleportationProvider
{
       /*[SerializeField]
        [Tooltip("The maximum teleportation distance allowed.")]
        private float maxTeleportDistance = 5f; // Distancia máxima permitida

        public float MaxTeleportDistance
        {
            get => maxTeleportDistance;
            set => maxTeleportDistance = value;
        }

        protected override void Update()
        {
            if (!validRequest)
            {
                locomotionPhase = LocomotionPhase.Idle;
                return;
            }

            var xrOrigin = system.xrOrigin;
            if (xrOrigin != null)
            {
                float distance = Vector3.Distance(currentRequest.destinationPosition, xrOrigin.transform.position);
                if (distance > maxTeleportDistance)
                {
                    Debug.Log("Teleport distance too far");
                    validRequest = false;
                    locomotionPhase = LocomotionPhase.Idle;
                    return;
                }
            }

            if (!m_HasExclusiveLocomotion)
            {
                if (!BeginLocomotion())
                    return;

                m_HasExclusiveLocomotion = true;
                locomotionPhase = LocomotionPhase.Started;
                m_TimeStarted = Time.time;
            }

            if (m_DelayTime > 0f && Time.time - m_TimeStarted < m_DelayTime)
                return;

            locomotionPhase = LocomotionPhase.Moving;

            if (xrOrigin != null)
            {
                switch (currentRequest.matchOrientation)
                {
                    case MatchOrientation.WorldSpaceUp:
                        xrOrigin.MatchOriginUp(Vector3.up);
                        break;
                    case MatchOrientation.TargetUp:
                        xrOrigin.MatchOriginUp(currentRequest.destinationRotation * Vector3.up);
                        break;
                    case MatchOrientation.TargetUpAndForward:
                        xrOrigin.MatchOriginUpCameraForward(currentRequest.destinationRotation * Vector3.up, currentRequest.destinationRotation * Vector3.forward);
                        break;
                    case MatchOrientation.None:
                        break;
                    default:
                        Assert.IsTrue(false, $"Unhandled {nameof(MatchOrientation)}={currentRequest.matchOrientation}.");
                        break;
                }

                var heightAdjustment = xrOrigin.Origin.transform.up * xrOrigin.CameraInOriginSpaceHeight;
                var cameraDestination = currentRequest.destinationPosition + heightAdjustment;
                xrOrigin.MoveCameraToWorldLocation(cameraDestination);
            }

            EndLocomotion();
            m_HasExclusiveLocomotion = false;
            validRequest = false;
            locomotionPhase = LocomotionPhase.Done;
        }      */
    }

