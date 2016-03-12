﻿namespace ReactiveQ
{
	public enum QbservableProtocolShutDownReason : byte
	{
		None,
		ProtocolNegotiationCancelled,
		ProtocolNegotiationError,
		ProtocolTerminated,
		ObservableTerminated,
		ClientTerminated,
		BadClientRequest,
		ExpressionSecurityViolation,
		ExpressionSubscriptionException,
		ServerError
	}
}