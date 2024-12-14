using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000553 RID: 1363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3SwapScRsp : IMessage<FightMatch3SwapScRsp>, IMessage, IEquatable<FightMatch3SwapScRsp>, IDeepCloneable<FightMatch3SwapScRsp>, IBufferMessage
	{
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x000A6847 File Offset: 0x000A4A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3SwapScRsp> Parser
		{
			get
			{
				return FightMatch3SwapScRsp._parser;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x000A684E File Offset: 0x000A4A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3SwapScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x000A6860 File Offset: 0x000A4A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3SwapScRsp.Descriptor;
			}
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x000A6867 File Offset: 0x000A4A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapScRsp()
		{
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x000A6870 File Offset: 0x000A4A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapScRsp(FightMatch3SwapScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mLGMDJKAPDJ_ = ((other.mLGMDJKAPDJ_ != null) ? other.mLGMDJKAPDJ_.Clone() : null);
			this.cGOLKEGJPOK_ = other.cGOLKEGJPOK_;
			this.pPBIIDKNIDA_ = other.pPBIIDKNIDA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x000A68D4 File Offset: 0x000A4AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3SwapScRsp Clone()
		{
			return new FightMatch3SwapScRsp(this);
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x000A68DC File Offset: 0x000A4ADC
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x000A68E4 File Offset: 0x000A4AE4
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x000A68ED File Offset: 0x000A4AED
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x000A68F5 File Offset: 0x000A4AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN MLGMDJKAPDJ
		{
			get
			{
				return this.mLGMDJKAPDJ_;
			}
			set
			{
				this.mLGMDJKAPDJ_ = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x000A68FE File Offset: 0x000A4AFE
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x000A6906 File Offset: 0x000A4B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CGOLKEGJPOK
		{
			get
			{
				return this.cGOLKEGJPOK_;
			}
			set
			{
				this.cGOLKEGJPOK_ = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x000A690F File Offset: 0x000A4B0F
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x000A6917 File Offset: 0x000A4B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPBIIDKNIDA
		{
			get
			{
				return this.pPBIIDKNIDA_;
			}
			set
			{
				this.pPBIIDKNIDA_ = value;
			}
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x000A6920 File Offset: 0x000A4B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3SwapScRsp);
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x000A6930 File Offset: 0x000A4B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3SwapScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.MLGMDJKAPDJ, other.MLGMDJKAPDJ) && this.CGOLKEGJPOK == other.CGOLKEGJPOK && this.PPBIIDKNIDA == other.PPBIIDKNIDA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x000A69A0 File Offset: 0x000A4BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.mLGMDJKAPDJ_ != null)
			{
				num ^= this.MLGMDJKAPDJ.GetHashCode();
			}
			if (this.CGOLKEGJPOK)
			{
				num ^= this.CGOLKEGJPOK.GetHashCode();
			}
			if (this.PPBIIDKNIDA != 0U)
			{
				num ^= this.PPBIIDKNIDA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000A6A27 File Offset: 0x000A4C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x000A6A2F File Offset: 0x000A4C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x000A6A38 File Offset: 0x000A4C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mLGMDJKAPDJ_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MLGMDJKAPDJ);
			}
			if (this.PPBIIDKNIDA != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PPBIIDKNIDA);
			}
			if (this.CGOLKEGJPOK)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.CGOLKEGJPOK);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000A6ACC File Offset: 0x000A4CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.mLGMDJKAPDJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MLGMDJKAPDJ);
			}
			if (this.CGOLKEGJPOK)
			{
				num += 2;
			}
			if (this.PPBIIDKNIDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPBIIDKNIDA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000A6B48 File Offset: 0x000A4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3SwapScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.mLGMDJKAPDJ_ != null)
			{
				if (this.mLGMDJKAPDJ_ == null)
				{
					this.MLGMDJKAPDJ = new KAKPHLOPDAN();
				}
				this.MLGMDJKAPDJ.MergeFrom(other.MLGMDJKAPDJ);
			}
			if (other.CGOLKEGJPOK)
			{
				this.CGOLKEGJPOK = other.CGOLKEGJPOK;
			}
			if (other.PPBIIDKNIDA != 0U)
			{
				this.PPBIIDKNIDA = other.PPBIIDKNIDA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000A6BD8 File Offset: 0x000A4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000A6BE4 File Offset: 0x000A4DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 26U)
					{
						if (this.mLGMDJKAPDJ_ == null)
						{
							this.MLGMDJKAPDJ = new KAKPHLOPDAN();
						}
						input.ReadMessage(this.MLGMDJKAPDJ);
						continue;
					}
					if (num == 48U)
					{
						this.PPBIIDKNIDA = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CGOLKEGJPOK = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400185E RID: 6238
		private static readonly MessageParser<FightMatch3SwapScRsp> _parser = new MessageParser<FightMatch3SwapScRsp>(() => new FightMatch3SwapScRsp());

		// Token: 0x0400185F RID: 6239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001860 RID: 6240
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001861 RID: 6241
		private uint retcode_;

		// Token: 0x04001862 RID: 6242
		public const int MLGMDJKAPDJFieldNumber = 3;

		// Token: 0x04001863 RID: 6243
		private KAKPHLOPDAN mLGMDJKAPDJ_;

		// Token: 0x04001864 RID: 6244
		public const int CGOLKEGJPOKFieldNumber = 12;

		// Token: 0x04001865 RID: 6245
		private bool cGOLKEGJPOK_;

		// Token: 0x04001866 RID: 6246
		public const int PPBIIDKNIDAFieldNumber = 6;

		// Token: 0x04001867 RID: 6247
		private uint pPBIIDKNIDA_;
	}
}
