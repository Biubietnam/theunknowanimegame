using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D5 RID: 4821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeExpeditionRewardScRsp : IMessage<TakeExpeditionRewardScRsp>, IMessage, IEquatable<TakeExpeditionRewardScRsp>, IDeepCloneable<TakeExpeditionRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600D70E RID: 55054 RVA: 0x0023D817 File Offset: 0x0023BA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeExpeditionRewardScRsp> Parser
		{
			get
			{
				return TakeExpeditionRewardScRsp._parser;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600D70F RID: 55055 RVA: 0x0023D81E File Offset: 0x0023BA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeExpeditionRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600D710 RID: 55056 RVA: 0x0023D830 File Offset: 0x0023BA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeExpeditionRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x0023D837 File Offset: 0x0023BA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardScRsp()
		{
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x0023D840 File Offset: 0x0023BA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardScRsp(TakeExpeditionRewardScRsp other) : this()
		{
			this.kCGOBOKNMFH_ = ((other.kCGOBOKNMFH_ != null) ? other.kCGOBOKNMFH_.Clone() : null);
			this.gLIEPFENPHH_ = other.gLIEPFENPHH_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x0023D8B4 File Offset: 0x0023BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardScRsp Clone()
		{
			return new TakeExpeditionRewardScRsp(this);
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600D714 RID: 55060 RVA: 0x0023D8BC File Offset: 0x0023BABC
		// (set) Token: 0x0600D715 RID: 55061 RVA: 0x0023D8C4 File Offset: 0x0023BAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList KCGOBOKNMFH
		{
			get
			{
				return this.kCGOBOKNMFH_;
			}
			set
			{
				this.kCGOBOKNMFH_ = value;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600D716 RID: 55062 RVA: 0x0023D8CD File Offset: 0x0023BACD
		// (set) Token: 0x0600D717 RID: 55063 RVA: 0x0023D8D5 File Offset: 0x0023BAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GLIEPFENPHH
		{
			get
			{
				return this.gLIEPFENPHH_;
			}
			set
			{
				this.gLIEPFENPHH_ = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600D718 RID: 55064 RVA: 0x0023D8DE File Offset: 0x0023BADE
		// (set) Token: 0x0600D719 RID: 55065 RVA: 0x0023D8E6 File Offset: 0x0023BAE6
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

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600D71A RID: 55066 RVA: 0x0023D8EF File Offset: 0x0023BAEF
		// (set) Token: 0x0600D71B RID: 55067 RVA: 0x0023D8F7 File Offset: 0x0023BAF7
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

		// Token: 0x0600D71C RID: 55068 RVA: 0x0023D900 File Offset: 0x0023BB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeExpeditionRewardScRsp);
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x0023D910 File Offset: 0x0023BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeExpeditionRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.KCGOBOKNMFH, other.KCGOBOKNMFH) && this.GLIEPFENPHH == other.GLIEPFENPHH && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x0023D984 File Offset: 0x0023BB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kCGOBOKNMFH_ != null)
			{
				num ^= this.KCGOBOKNMFH.GetHashCode();
			}
			if (this.GLIEPFENPHH != 0U)
			{
				num ^= this.GLIEPFENPHH.GetHashCode();
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

		// Token: 0x0600D71F RID: 55071 RVA: 0x0023DA08 File Offset: 0x0023BC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x0023DA10 File Offset: 0x0023BC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D721 RID: 55073 RVA: 0x0023DA1C File Offset: 0x0023BC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GLIEPFENPHH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GLIEPFENPHH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.KCGOBOKNMFH);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x0023DAAC File Offset: 0x0023BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kCGOBOKNMFH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KCGOBOKNMFH);
			}
			if (this.GLIEPFENPHH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLIEPFENPHH);
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

		// Token: 0x0600D723 RID: 55075 RVA: 0x0023DB34 File Offset: 0x0023BD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeExpeditionRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kCGOBOKNMFH_ != null)
			{
				if (this.kCGOBOKNMFH_ == null)
				{
					this.KCGOBOKNMFH = new ItemList();
				}
				this.KCGOBOKNMFH.MergeFrom(other.KCGOBOKNMFH);
			}
			if (other.GLIEPFENPHH != 0U)
			{
				this.GLIEPFENPHH = other.GLIEPFENPHH;
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

		// Token: 0x0600D724 RID: 55076 RVA: 0x0023DBDC File Offset: 0x0023BDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D725 RID: 55077 RVA: 0x0023DBE8 File Offset: 0x0023BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.GLIEPFENPHH = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.kCGOBOKNMFH_ == null)
						{
							this.KCGOBOKNMFH = new ItemList();
						}
						input.ReadMessage(this.KCGOBOKNMFH);
						continue;
					}
					if (num == 42U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055D6 RID: 21974
		private static readonly MessageParser<TakeExpeditionRewardScRsp> _parser = new MessageParser<TakeExpeditionRewardScRsp>(() => new TakeExpeditionRewardScRsp());

		// Token: 0x040055D7 RID: 21975
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D8 RID: 21976
		public const int KCGOBOKNMFHFieldNumber = 4;

		// Token: 0x040055D9 RID: 21977
		private ItemList kCGOBOKNMFH_;

		// Token: 0x040055DA RID: 21978
		public const int GLIEPFENPHHFieldNumber = 1;

		// Token: 0x040055DB RID: 21979
		private uint gLIEPFENPHH_;

		// Token: 0x040055DC RID: 21980
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040055DD RID: 21981
		private uint retcode_;

		// Token: 0x040055DE RID: 21982
		public const int RewardFieldNumber = 5;

		// Token: 0x040055DF RID: 21983
		private ItemList reward_;
	}
}
