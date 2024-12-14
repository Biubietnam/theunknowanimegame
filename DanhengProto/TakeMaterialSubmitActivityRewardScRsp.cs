using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E9 RID: 4841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMaterialSubmitActivityRewardScRsp : IMessage<TakeMaterialSubmitActivityRewardScRsp>, IMessage, IEquatable<TakeMaterialSubmitActivityRewardScRsp>, IDeepCloneable<TakeMaterialSubmitActivityRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x00240133 File Offset: 0x0023E333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMaterialSubmitActivityRewardScRsp> Parser
		{
			get
			{
				return TakeMaterialSubmitActivityRewardScRsp._parser;
			}
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600D803 RID: 55299 RVA: 0x0024013A File Offset: 0x0023E33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMaterialSubmitActivityRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0024014C File Offset: 0x0023E34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMaterialSubmitActivityRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x00240153 File Offset: 0x0023E353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardScRsp()
		{
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x0024015C File Offset: 0x0023E35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardScRsp(TakeMaterialSubmitActivityRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.nCEJNFFMGGF_ = other.nCEJNFFMGGF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x002401B4 File Offset: 0x0023E3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardScRsp Clone()
		{
			return new TakeMaterialSubmitActivityRewardScRsp(this);
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600D808 RID: 55304 RVA: 0x002401BC File Offset: 0x0023E3BC
		// (set) Token: 0x0600D809 RID: 55305 RVA: 0x002401C4 File Offset: 0x0023E3C4
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

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600D80A RID: 55306 RVA: 0x002401CD File Offset: 0x0023E3CD
		// (set) Token: 0x0600D80B RID: 55307 RVA: 0x002401D5 File Offset: 0x0023E3D5
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

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600D80C RID: 55308 RVA: 0x002401DE File Offset: 0x0023E3DE
		// (set) Token: 0x0600D80D RID: 55309 RVA: 0x002401E6 File Offset: 0x0023E3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCEJNFFMGGF
		{
			get
			{
				return this.nCEJNFFMGGF_;
			}
			set
			{
				this.nCEJNFFMGGF_ = value;
			}
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x002401EF File Offset: 0x0023E3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMaterialSubmitActivityRewardScRsp);
		}

		// Token: 0x0600D80F RID: 55311 RVA: 0x00240200 File Offset: 0x0023E400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMaterialSubmitActivityRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.NCEJNFFMGGF == other.NCEJNFFMGGF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D810 RID: 55312 RVA: 0x00240260 File Offset: 0x0023E460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NCEJNFFMGGF != 0U)
			{
				num ^= this.NCEJNFFMGGF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x002402CE File Offset: 0x0023E4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x002402D6 File Offset: 0x0023E4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x002402E0 File Offset: 0x0023E4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCEJNFFMGGF != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NCEJNFFMGGF);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
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

		// Token: 0x0600D814 RID: 55316 RVA: 0x00240358 File Offset: 0x0023E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NCEJNFFMGGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D815 RID: 55317 RVA: 0x002403C8 File Offset: 0x0023E5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMaterialSubmitActivityRewardScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NCEJNFFMGGF != 0U)
			{
				this.NCEJNFFMGGF = other.NCEJNFFMGGF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x00240444 File Offset: 0x0023E644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x00240450 File Offset: 0x0023E650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
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
					this.NCEJNFFMGGF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005632 RID: 22066
		private static readonly MessageParser<TakeMaterialSubmitActivityRewardScRsp> _parser = new MessageParser<TakeMaterialSubmitActivityRewardScRsp>(() => new TakeMaterialSubmitActivityRewardScRsp());

		// Token: 0x04005633 RID: 22067
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005634 RID: 22068
		public const int RewardFieldNumber = 13;

		// Token: 0x04005635 RID: 22069
		private ItemList reward_;

		// Token: 0x04005636 RID: 22070
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04005637 RID: 22071
		private uint retcode_;

		// Token: 0x04005638 RID: 22072
		public const int NCEJNFFMGGFFieldNumber = 3;

		// Token: 0x04005639 RID: 22073
		private uint nCEJNFFMGGF_;
	}
}
