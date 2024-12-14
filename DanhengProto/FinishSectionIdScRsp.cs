using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000599 RID: 1433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishSectionIdScRsp : IMessage<FinishSectionIdScRsp>, IMessage, IEquatable<FinishSectionIdScRsp>, IDeepCloneable<FinishSectionIdScRsp>, IBufferMessage
	{
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x000AE2D9 File Offset: 0x000AC4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishSectionIdScRsp> Parser
		{
			get
			{
				return FinishSectionIdScRsp._parser;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000AE2E0 File Offset: 0x000AC4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishSectionIdScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x000AE2F2 File Offset: 0x000AC4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishSectionIdScRsp.Descriptor;
			}
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x000AE2F9 File Offset: 0x000AC4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdScRsp()
		{
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x000AE304 File Offset: 0x000AC504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdScRsp(FinishSectionIdScRsp other) : this()
		{
			this.sectionId_ = other.sectionId_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000AE35C File Offset: 0x000AC55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdScRsp Clone()
		{
			return new FinishSectionIdScRsp(this);
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x000AE364 File Offset: 0x000AC564
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x000AE36C File Offset: 0x000AC56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x000AE375 File Offset: 0x000AC575
		// (set) Token: 0x06003FF9 RID: 16377 RVA: 0x000AE37D File Offset: 0x000AC57D
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06003FFA RID: 16378 RVA: 0x000AE386 File Offset: 0x000AC586
		// (set) Token: 0x06003FFB RID: 16379 RVA: 0x000AE38E File Offset: 0x000AC58E
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

		// Token: 0x06003FFC RID: 16380 RVA: 0x000AE397 File Offset: 0x000AC597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishSectionIdScRsp);
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x000AE3A8 File Offset: 0x000AC5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishSectionIdScRsp other)
		{
			return other != null && (other == this || (this.SectionId == other.SectionId && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000AE408 File Offset: 0x000AC608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x000AE476 File Offset: 0x000AC676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x000AE47E File Offset: 0x000AC67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000AE488 File Offset: 0x000AC688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SectionId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000AE500 File Offset: 0x000AC700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x000AE570 File Offset: 0x000AC770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishSectionIdScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x000AE5EC File Offset: 0x000AC7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x000AE5F8 File Offset: 0x000AC7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 96U)
					{
						if (num != 106U)
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
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.SectionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001965 RID: 6501
		private static readonly MessageParser<FinishSectionIdScRsp> _parser = new MessageParser<FinishSectionIdScRsp>(() => new FinishSectionIdScRsp());

		// Token: 0x04001966 RID: 6502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001967 RID: 6503
		public const int SectionIdFieldNumber = 8;

		// Token: 0x04001968 RID: 6504
		private uint sectionId_;

		// Token: 0x04001969 RID: 6505
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400196A RID: 6506
		private uint retcode_;

		// Token: 0x0400196B RID: 6507
		public const int RewardFieldNumber = 13;

		// Token: 0x0400196C RID: 6508
		private ItemList reward_;
	}
}
