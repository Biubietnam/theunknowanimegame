using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100B RID: 4107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournReviveAvatarScRsp : IMessage<RogueTournReviveAvatarScRsp>, IMessage, IEquatable<RogueTournReviveAvatarScRsp>, IDeepCloneable<RogueTournReviveAvatarScRsp>, IBufferMessage
	{
		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600B6BA RID: 46778 RVA: 0x001EA30F File Offset: 0x001E850F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournReviveAvatarScRsp> Parser
		{
			get
			{
				return RogueTournReviveAvatarScRsp._parser;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x001EA316 File Offset: 0x001E8516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournReviveAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600B6BC RID: 46780 RVA: 0x001EA328 File Offset: 0x001E8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournReviveAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x001EA32F File Offset: 0x001E852F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarScRsp()
		{
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x001EA338 File Offset: 0x001E8538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarScRsp(RogueTournReviveAvatarScRsp other) : this()
		{
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x001EA384 File Offset: 0x001E8584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveAvatarScRsp Clone()
		{
			return new RogueTournReviveAvatarScRsp(this);
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600B6C0 RID: 46784 RVA: 0x001EA38C File Offset: 0x001E858C
		// (set) Token: 0x0600B6C1 RID: 46785 RVA: 0x001EA394 File Offset: 0x001E8594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600B6C2 RID: 46786 RVA: 0x001EA39D File Offset: 0x001E859D
		// (set) Token: 0x0600B6C3 RID: 46787 RVA: 0x001EA3A5 File Offset: 0x001E85A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x001EA3AE File Offset: 0x001E85AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournReviveAvatarScRsp);
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x001EA3BC File Offset: 0x001E85BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournReviveAvatarScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueReviveCost, other.RogueReviveCost) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x001EA40C File Offset: 0x001E860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x001EA461 File Offset: 0x001E8661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x001EA469 File Offset: 0x001E8669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x001EA474 File Offset: 0x001E8674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x001EA4D0 File Offset: 0x001E86D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x001EA528 File Offset: 0x001E8728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournReviveAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x001EA590 File Offset: 0x001E8790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x001EA59C File Offset: 0x001E879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueReviveCost_ == null)
						{
							this.RogueReviveCost = new ItemCostData();
						}
						input.ReadMessage(this.RogueReviveCost);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004A04 RID: 18948
		private static readonly MessageParser<RogueTournReviveAvatarScRsp> _parser = new MessageParser<RogueTournReviveAvatarScRsp>(() => new RogueTournReviveAvatarScRsp());

		// Token: 0x04004A05 RID: 18949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A06 RID: 18950
		public const int RogueReviveCostFieldNumber = 13;

		// Token: 0x04004A07 RID: 18951
		private ItemCostData rogueReviveCost_;

		// Token: 0x04004A08 RID: 18952
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004A09 RID: 18953
		private uint retcode_;
	}
}
