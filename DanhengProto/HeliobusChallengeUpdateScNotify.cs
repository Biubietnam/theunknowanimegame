using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B9 RID: 2233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusChallengeUpdateScNotify : IMessage<HeliobusChallengeUpdateScNotify>, IMessage, IEquatable<HeliobusChallengeUpdateScNotify>, IDeepCloneable<HeliobusChallengeUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x0600638C RID: 25484 RVA: 0x0010ABBD File Offset: 0x00108DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusChallengeUpdateScNotify> Parser
		{
			get
			{
				return HeliobusChallengeUpdateScNotify._parser;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x0010ABC4 File Offset: 0x00108DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusChallengeUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x0010ABD6 File Offset: 0x00108DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusChallengeUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0010ABDD File Offset: 0x00108DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeUpdateScNotify()
		{
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0010ABE5 File Offset: 0x00108DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeUpdateScNotify(HeliobusChallengeUpdateScNotify other) : this()
		{
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0010AC1A File Offset: 0x00108E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeUpdateScNotify Clone()
		{
			return new HeliobusChallengeUpdateScNotify(this);
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x0010AC22 File Offset: 0x00108E22
		// (set) Token: 0x06006393 RID: 25491 RVA: 0x0010AC2A File Offset: 0x00108E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeList Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
			}
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0010AC33 File Offset: 0x00108E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusChallengeUpdateScNotify);
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x0010AC41 File Offset: 0x00108E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusChallengeUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Challenge, other.Challenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0010AC74 File Offset: 0x00108E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0010ACB0 File Offset: 0x00108EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x0010ACB8 File Offset: 0x00108EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0010ACC1 File Offset: 0x00108EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challenge_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0010ACF4 File Offset: 0x00108EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x0010AD34 File Offset: 0x00108F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusChallengeUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new ChallengeList();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x0010AD88 File Offset: 0x00108F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x0010AD94 File Offset: 0x00108F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.challenge_ == null)
					{
						this.Challenge = new ChallengeList();
					}
					input.ReadMessage(this.Challenge);
				}
			}
		}

		// Token: 0x04002665 RID: 9829
		private static readonly MessageParser<HeliobusChallengeUpdateScNotify> _parser = new MessageParser<HeliobusChallengeUpdateScNotify>(() => new HeliobusChallengeUpdateScNotify());

		// Token: 0x04002666 RID: 9830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002667 RID: 9831
		public const int ChallengeFieldNumber = 9;

		// Token: 0x04002668 RID: 9832
		private ChallengeList challenge_;
	}
}
