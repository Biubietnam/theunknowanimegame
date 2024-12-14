using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E5F RID: 3679
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonPendingAction : IMessage<RogueCommonPendingAction>, IMessage, IEquatable<RogueCommonPendingAction>, IDeepCloneable<RogueCommonPendingAction>, IBufferMessage
	{
		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600A417 RID: 42007 RVA: 0x001B922D File Offset: 0x001B742D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonPendingAction> Parser
		{
			get
			{
				return RogueCommonPendingAction._parser;
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600A418 RID: 42008 RVA: 0x001B9234 File Offset: 0x001B7434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonPendingActionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x001B9246 File Offset: 0x001B7446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonPendingAction.Descriptor;
			}
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x001B924D File Offset: 0x001B744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction()
		{
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x001B9258 File Offset: 0x001B7458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction(RogueCommonPendingAction other) : this()
		{
			this.queuePosition_ = other.queuePosition_;
			this.rogueAction_ = ((other.rogueAction_ != null) ? other.rogueAction_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x001B92A4 File Offset: 0x001B74A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction Clone()
		{
			return new RogueCommonPendingAction(this);
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600A41D RID: 42013 RVA: 0x001B92AC File Offset: 0x001B74AC
		// (set) Token: 0x0600A41E RID: 42014 RVA: 0x001B92B4 File Offset: 0x001B74B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QueuePosition
		{
			get
			{
				return this.queuePosition_;
			}
			set
			{
				this.queuePosition_ = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600A41F RID: 42015 RVA: 0x001B92BD File Offset: 0x001B74BD
		// (set) Token: 0x0600A420 RID: 42016 RVA: 0x001B92C5 File Offset: 0x001B74C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAction RogueAction
		{
			get
			{
				return this.rogueAction_;
			}
			set
			{
				this.rogueAction_ = value;
			}
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x001B92CE File Offset: 0x001B74CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonPendingAction);
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x001B92DC File Offset: 0x001B74DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonPendingAction other)
		{
			return other != null && (other == this || (this.QueuePosition == other.QueuePosition && object.Equals(this.RogueAction, other.RogueAction) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x001B932C File Offset: 0x001B752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QueuePosition != 0U)
			{
				num ^= this.QueuePosition.GetHashCode();
			}
			if (this.rogueAction_ != null)
			{
				num ^= this.RogueAction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x001B9381 File Offset: 0x001B7581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x001B9389 File Offset: 0x001B7589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x001B9394 File Offset: 0x001B7594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueAction_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueAction);
			}
			if (this.QueuePosition != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.QueuePosition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x001B93F0 File Offset: 0x001B75F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QueuePosition != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueuePosition);
			}
			if (this.rogueAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x001B9448 File Offset: 0x001B7648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonPendingAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QueuePosition != 0U)
			{
				this.QueuePosition = other.QueuePosition;
			}
			if (other.rogueAction_ != null)
			{
				if (this.rogueAction_ == null)
				{
					this.RogueAction = new RogueAction();
				}
				this.RogueAction.MergeFrom(other.RogueAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x001B94B0 File Offset: 0x001B76B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x001B94BC File Offset: 0x001B76BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QueuePosition = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueAction_ == null)
					{
						this.RogueAction = new RogueAction();
					}
					input.ReadMessage(this.RogueAction);
				}
			}
		}

		// Token: 0x04004319 RID: 17177
		private static readonly MessageParser<RogueCommonPendingAction> _parser = new MessageParser<RogueCommonPendingAction>(() => new RogueCommonPendingAction());

		// Token: 0x0400431A RID: 17178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400431B RID: 17179
		public const int QueuePositionFieldNumber = 7;

		// Token: 0x0400431C RID: 17180
		private uint queuePosition_;

		// Token: 0x0400431D RID: 17181
		public const int RogueActionFieldNumber = 6;

		// Token: 0x0400431E RID: 17182
		private RogueAction rogueAction_;
	}
}
