using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012FF RID: 4863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOfferingRewardScRsp : IMessage<TakeOfferingRewardScRsp>, IMessage, IEquatable<TakeOfferingRewardScRsp>, IDeepCloneable<TakeOfferingRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x0024261B File Offset: 0x0024081B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOfferingRewardScRsp> Parser
		{
			get
			{
				return TakeOfferingRewardScRsp._parser;
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600D8F9 RID: 55545 RVA: 0x00242622 File Offset: 0x00240822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOfferingRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x00242634 File Offset: 0x00240834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOfferingRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x0024263B File Offset: 0x0024083B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardScRsp()
		{
		}

		// Token: 0x0600D8FC RID: 55548 RVA: 0x00242644 File Offset: 0x00240844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardScRsp(TakeOfferingRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.jLEFMLADEHI_ = ((other.jLEFMLADEHI_ != null) ? other.jLEFMLADEHI_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8FD RID: 55549 RVA: 0x002426AC File Offset: 0x002408AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardScRsp Clone()
		{
			return new TakeOfferingRewardScRsp(this);
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x002426B4 File Offset: 0x002408B4
		// (set) Token: 0x0600D8FF RID: 55551 RVA: 0x002426BC File Offset: 0x002408BC
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

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x002426C5 File Offset: 0x002408C5
		// (set) Token: 0x0600D901 RID: 55553 RVA: 0x002426CD File Offset: 0x002408CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG JLEFMLADEHI
		{
			get
			{
				return this.jLEFMLADEHI_;
			}
			set
			{
				this.jLEFMLADEHI_ = value;
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600D902 RID: 55554 RVA: 0x002426D6 File Offset: 0x002408D6
		// (set) Token: 0x0600D903 RID: 55555 RVA: 0x002426DE File Offset: 0x002408DE
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

		// Token: 0x0600D904 RID: 55556 RVA: 0x002426E7 File Offset: 0x002408E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOfferingRewardScRsp);
		}

		// Token: 0x0600D905 RID: 55557 RVA: 0x002426F8 File Offset: 0x002408F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOfferingRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && object.Equals(this.JLEFMLADEHI, other.JLEFMLADEHI) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D906 RID: 55558 RVA: 0x0024275C File Offset: 0x0024095C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.jLEFMLADEHI_ != null)
			{
				num ^= this.JLEFMLADEHI.GetHashCode();
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

		// Token: 0x0600D907 RID: 55559 RVA: 0x002427C7 File Offset: 0x002409C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x002427CF File Offset: 0x002409CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D909 RID: 55561 RVA: 0x002427D8 File Offset: 0x002409D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.jLEFMLADEHI_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.JLEFMLADEHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D90A RID: 55562 RVA: 0x00242850 File Offset: 0x00240A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.jLEFMLADEHI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JLEFMLADEHI);
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

		// Token: 0x0600D90B RID: 55563 RVA: 0x002428C0 File Offset: 0x00240AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOfferingRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.jLEFMLADEHI_ != null)
			{
				if (this.jLEFMLADEHI_ == null)
				{
					this.JLEFMLADEHI = new POPDHFEBLPG();
				}
				this.JLEFMLADEHI.MergeFrom(other.JLEFMLADEHI);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D90C RID: 55564 RVA: 0x00242954 File Offset: 0x00240B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x00242960 File Offset: 0x00240B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 80U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.jLEFMLADEHI_ == null)
							{
								this.JLEFMLADEHI = new POPDHFEBLPG();
							}
							input.ReadMessage(this.JLEFMLADEHI);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
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
		}

		// Token: 0x04005686 RID: 22150
		private static readonly MessageParser<TakeOfferingRewardScRsp> _parser = new MessageParser<TakeOfferingRewardScRsp>(() => new TakeOfferingRewardScRsp());

		// Token: 0x04005687 RID: 22151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005688 RID: 22152
		public const int RewardFieldNumber = 3;

		// Token: 0x04005689 RID: 22153
		private ItemList reward_;

		// Token: 0x0400568A RID: 22154
		public const int JLEFMLADEHIFieldNumber = 11;

		// Token: 0x0400568B RID: 22155
		private POPDHFEBLPG jLEFMLADEHI_;

		// Token: 0x0400568C RID: 22156
		public const int RetcodeFieldNumber = 10;

		// Token: 0x0400568D RID: 22157
		private uint retcode_;
	}
}
