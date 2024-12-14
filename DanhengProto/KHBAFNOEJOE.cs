using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009A3 RID: 2467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KHBAFNOEJOE : IMessage<KHBAFNOEJOE>, IMessage, IEquatable<KHBAFNOEJOE>, IDeepCloneable<KHBAFNOEJOE>, IBufferMessage
	{
		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06006E48 RID: 28232 RVA: 0x001269D5 File Offset: 0x00124BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KHBAFNOEJOE> Parser
		{
			get
			{
				return KHBAFNOEJOE._parser;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x001269DC File Offset: 0x00124BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KHBAFNOEJOEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x001269EE File Offset: 0x00124BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KHBAFNOEJOE.Descriptor;
			}
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x001269F5 File Offset: 0x00124BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHBAFNOEJOE()
		{
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x001269FD File Offset: 0x00124BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHBAFNOEJOE(KHBAFNOEJOE other) : this()
		{
			this.isTakenReward_ = other.isTakenReward_;
			this.eDCFJPGIEAK_ = other.eDCFJPGIEAK_;
			this.aEFCHHPLPCA_ = other.aEFCHHPLPCA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x00126A3A File Offset: 0x00124C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHBAFNOEJOE Clone()
		{
			return new KHBAFNOEJOE(this);
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x00126A42 File Offset: 0x00124C42
		// (set) Token: 0x06006E4F RID: 28239 RVA: 0x00126A4A File Offset: 0x00124C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakenReward
		{
			get
			{
				return this.isTakenReward_;
			}
			set
			{
				this.isTakenReward_ = value;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x00126A53 File Offset: 0x00124C53
		// (set) Token: 0x06006E51 RID: 28241 RVA: 0x00126A5B File Offset: 0x00124C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EDCFJPGIEAK
		{
			get
			{
				return this.eDCFJPGIEAK_;
			}
			set
			{
				this.eDCFJPGIEAK_ = value;
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x00126A64 File Offset: 0x00124C64
		// (set) Token: 0x06006E53 RID: 28243 RVA: 0x00126A6C File Offset: 0x00124C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong AEFCHHPLPCA
		{
			get
			{
				return this.aEFCHHPLPCA_;
			}
			set
			{
				this.aEFCHHPLPCA_ = value;
			}
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x00126A75 File Offset: 0x00124C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KHBAFNOEJOE);
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x00126A84 File Offset: 0x00124C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KHBAFNOEJOE other)
		{
			return other != null && (other == this || (this.IsTakenReward == other.IsTakenReward && this.EDCFJPGIEAK == other.EDCFJPGIEAK && this.AEFCHHPLPCA == other.AEFCHHPLPCA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x00126AE0 File Offset: 0x00124CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.EDCFJPGIEAK)
			{
				num ^= this.EDCFJPGIEAK.GetHashCode();
			}
			if (this.AEFCHHPLPCA != 0UL)
			{
				num ^= this.AEFCHHPLPCA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x00126B51 File Offset: 0x00124D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00126B59 File Offset: 0x00124D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00126B64 File Offset: 0x00124D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AEFCHHPLPCA != 0UL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.AEFCHHPLPCA);
			}
			if (this.EDCFJPGIEAK)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.EDCFJPGIEAK);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsTakenReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00126BDC File Offset: 0x00124DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.EDCFJPGIEAK)
			{
				num += 2;
			}
			if (this.AEFCHHPLPCA != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AEFCHHPLPCA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x00126C34 File Offset: 0x00124E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KHBAFNOEJOE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.EDCFJPGIEAK)
			{
				this.EDCFJPGIEAK = other.EDCFJPGIEAK;
			}
			if (other.AEFCHHPLPCA != 0UL)
			{
				this.AEFCHHPLPCA = other.AEFCHHPLPCA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x00126C98 File Offset: 0x00124E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00126CA4 File Offset: 0x00124EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsTakenReward = input.ReadBool();
						}
					}
					else
					{
						this.EDCFJPGIEAK = input.ReadBool();
					}
				}
				else
				{
					this.AEFCHHPLPCA = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04002A59 RID: 10841
		private static readonly MessageParser<KHBAFNOEJOE> _parser = new MessageParser<KHBAFNOEJOE>(() => new KHBAFNOEJOE());

		// Token: 0x04002A5A RID: 10842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A5B RID: 10843
		public const int IsTakenRewardFieldNumber = 15;

		// Token: 0x04002A5C RID: 10844
		private bool isTakenReward_;

		// Token: 0x04002A5D RID: 10845
		public const int EDCFJPGIEAKFieldNumber = 12;

		// Token: 0x04002A5E RID: 10846
		private bool eDCFJPGIEAK_;

		// Token: 0x04002A5F RID: 10847
		public const int AEFCHHPLPCAFieldNumber = 9;

		// Token: 0x04002A60 RID: 10848
		private ulong aEFCHHPLPCA_;
	}
}
