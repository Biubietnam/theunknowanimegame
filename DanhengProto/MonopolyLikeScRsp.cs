using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B5F RID: 2911
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyLikeScRsp : IMessage<MonopolyLikeScRsp>, IMessage, IEquatable<MonopolyLikeScRsp>, IDeepCloneable<MonopolyLikeScRsp>, IBufferMessage
	{
		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x001539F9 File Offset: 0x00151BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyLikeScRsp> Parser
		{
			get
			{
				return MonopolyLikeScRsp._parser;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x00153A00 File Offset: 0x00151C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyLikeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x060080D1 RID: 32977 RVA: 0x00153A12 File Offset: 0x00151C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyLikeScRsp.Descriptor;
			}
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x00153A19 File Offset: 0x00151C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScRsp()
		{
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x00153A24 File Offset: 0x00151C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScRsp(MonopolyLikeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bEJLJKLPFHI_ = other.bEJLJKLPFHI_;
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x00153A7C File Offset: 0x00151C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScRsp Clone()
		{
			return new MonopolyLikeScRsp(this);
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x00153A84 File Offset: 0x00151C84
		// (set) Token: 0x060080D6 RID: 32982 RVA: 0x00153A8C File Offset: 0x00151C8C
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

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060080D7 RID: 32983 RVA: 0x00153A95 File Offset: 0x00151C95
		// (set) Token: 0x060080D8 RID: 32984 RVA: 0x00153A9D File Offset: 0x00151C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BEJLJKLPFHI
		{
			get
			{
				return this.bEJLJKLPFHI_;
			}
			set
			{
				this.bEJLJKLPFHI_ = value;
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x00153AA6 File Offset: 0x00151CA6
		// (set) Token: 0x060080DA RID: 32986 RVA: 0x00153AAE File Offset: 0x00151CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList RewardList
		{
			get
			{
				return this.rewardList_;
			}
			set
			{
				this.rewardList_ = value;
			}
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x00153AB7 File Offset: 0x00151CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyLikeScRsp);
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x00153AC8 File Offset: 0x00151CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyLikeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.BEJLJKLPFHI == other.BEJLJKLPFHI && object.Equals(this.RewardList, other.RewardList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x00153B28 File Offset: 0x00151D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.BEJLJKLPFHI != 0U)
			{
				num ^= this.BEJLJKLPFHI.GetHashCode();
			}
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x00153B96 File Offset: 0x00151D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00153B9E File Offset: 0x00151D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00153BA8 File Offset: 0x00151DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RewardList);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.BEJLJKLPFHI != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BEJLJKLPFHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00153C20 File Offset: 0x00151E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.BEJLJKLPFHI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BEJLJKLPFHI);
			}
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00153C90 File Offset: 0x00151E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyLikeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.BEJLJKLPFHI != 0U)
			{
				this.BEJLJKLPFHI = other.BEJLJKLPFHI;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00153D0C File Offset: 0x00151F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00153D18 File Offset: 0x00151F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BEJLJKLPFHI = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rewardList_ == null)
					{
						this.RewardList = new ItemList();
					}
					input.ReadMessage(this.RewardList);
				}
			}
		}

		// Token: 0x04003134 RID: 12596
		private static readonly MessageParser<MonopolyLikeScRsp> _parser = new MessageParser<MonopolyLikeScRsp>(() => new MonopolyLikeScRsp());

		// Token: 0x04003135 RID: 12597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003136 RID: 12598
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04003137 RID: 12599
		private uint retcode_;

		// Token: 0x04003138 RID: 12600
		public const int BEJLJKLPFHIFieldNumber = 11;

		// Token: 0x04003139 RID: 12601
		private uint bEJLJKLPFHI_;

		// Token: 0x0400313A RID: 12602
		public const int RewardListFieldNumber = 8;

		// Token: 0x0400313B RID: 12603
		private ItemList rewardList_;
	}
}
