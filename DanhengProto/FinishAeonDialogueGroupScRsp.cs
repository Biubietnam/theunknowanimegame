using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000561 RID: 1377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishAeonDialogueGroupScRsp : IMessage<FinishAeonDialogueGroupScRsp>, IMessage, IEquatable<FinishAeonDialogueGroupScRsp>, IDeepCloneable<FinishAeonDialogueGroupScRsp>, IBufferMessage
	{
		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x000A810F File Offset: 0x000A630F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishAeonDialogueGroupScRsp> Parser
		{
			get
			{
				return FinishAeonDialogueGroupScRsp._parser;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x000A8116 File Offset: 0x000A6316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x000A8128 File Offset: 0x000A6328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupScRsp.Descriptor;
			}
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x000A812F File Offset: 0x000A632F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupScRsp()
		{
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x000A8138 File Offset: 0x000A6338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupScRsp(FinishAeonDialogueGroupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x000A81A0 File Offset: 0x000A63A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupScRsp Clone()
		{
			return new FinishAeonDialogueGroupScRsp(this);
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x000A81A8 File Offset: 0x000A63A8
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x000A81B0 File Offset: 0x000A63B0
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

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x000A81B9 File Offset: 0x000A63B9
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x000A81C1 File Offset: 0x000A63C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x000A81CA File Offset: 0x000A63CA
		// (set) Token: 0x06003D6C RID: 15724 RVA: 0x000A81D2 File Offset: 0x000A63D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALFJMIPDIBO RogueAeonInfo
		{
			get
			{
				return this.rogueAeonInfo_;
			}
			set
			{
				this.rogueAeonInfo_ = value;
			}
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x000A81DB File Offset: 0x000A63DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishAeonDialogueGroupScRsp);
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x000A81EC File Offset: 0x000A63EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishAeonDialogueGroupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x000A8250 File Offset: 0x000A6450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x000A82BB File Offset: 0x000A64BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x000A82C3 File Offset: 0x000A64C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x000A82CC File Offset: 0x000A64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x000A8344 File Offset: 0x000A6544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x000A83B4 File Offset: 0x000A65B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishAeonDialogueGroupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new ALFJMIPDIBO();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x000A8448 File Offset: 0x000A6648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x000A8454 File Offset: 0x000A6654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 82U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.reward_ == null)
							{
								this.Reward = new ItemList();
							}
							input.ReadMessage(this.Reward);
						}
					}
					else
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new ALFJMIPDIBO();
						}
						input.ReadMessage(this.RogueAeonInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001890 RID: 6288
		private static readonly MessageParser<FinishAeonDialogueGroupScRsp> _parser = new MessageParser<FinishAeonDialogueGroupScRsp>(() => new FinishAeonDialogueGroupScRsp());

		// Token: 0x04001891 RID: 6289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001892 RID: 6290
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001893 RID: 6291
		private uint retcode_;

		// Token: 0x04001894 RID: 6292
		public const int RewardFieldNumber = 12;

		// Token: 0x04001895 RID: 6293
		private ItemList reward_;

		// Token: 0x04001896 RID: 6294
		public const int RogueAeonInfoFieldNumber = 10;

		// Token: 0x04001897 RID: 6295
		private ALFJMIPDIBO rogueAeonInfo_;
	}
}
