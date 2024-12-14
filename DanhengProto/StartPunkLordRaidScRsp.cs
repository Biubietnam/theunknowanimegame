using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011BF RID: 4543
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartPunkLordRaidScRsp : IMessage<StartPunkLordRaidScRsp>, IMessage, IEquatable<StartPunkLordRaidScRsp>, IDeepCloneable<StartPunkLordRaidScRsp>, IBufferMessage
	{
		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600CAEC RID: 51948 RVA: 0x00220687 File Offset: 0x0021E887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartPunkLordRaidScRsp> Parser
		{
			get
			{
				return StartPunkLordRaidScRsp._parser;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600CAED RID: 51949 RVA: 0x0022068E File Offset: 0x0021E88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartPunkLordRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x002206A0 File Offset: 0x0021E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartPunkLordRaidScRsp.Descriptor;
			}
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x002206A7 File Offset: 0x0021E8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidScRsp()
		{
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x002206BC File Offset: 0x0021E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidScRsp(StartPunkLordRaidScRsp other) : this()
		{
			this.fDDFAKGGPGF_ = other.fDDFAKGGPGF_.Clone();
			this.retcode_ = other.retcode_;
			this.eBBHDIDOOKI_ = other.eBBHDIDOOKI_;
			this.iOEBEBCENHO_ = ((other.iOEBEBCENHO_ != null) ? other.iOEBEBCENHO_.Clone() : null);
			this.kEPHAGKCAGK_ = other.kEPHAGKCAGK_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x0022074D File Offset: 0x0021E94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidScRsp Clone()
		{
			return new StartPunkLordRaidScRsp(this);
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x00220755 File Offset: 0x0021E955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FDDFAKGGPGF
		{
			get
			{
				return this.fDDFAKGGPGF_;
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x0022075D File Offset: 0x0021E95D
		// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x00220765 File Offset: 0x0021E965
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

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x0022076E File Offset: 0x0021E96E
		// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00220776 File Offset: 0x0021E976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EBBHDIDOOKI
		{
			get
			{
				return this.eBBHDIDOOKI_;
			}
			set
			{
				this.eBBHDIDOOKI_ = value;
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x0022077F File Offset: 0x0021E97F
		// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00220787 File Offset: 0x0021E987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLAPEBCMOO IOEBEBCENHO
		{
			get
			{
				return this.iOEBEBCENHO_;
			}
			set
			{
				this.iOEBEBCENHO_ = value;
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00220790 File Offset: 0x0021E990
		// (set) Token: 0x0600CAFA RID: 51962 RVA: 0x00220798 File Offset: 0x0021E998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KEPHAGKCAGK
		{
			get
			{
				return this.kEPHAGKCAGK_;
			}
			set
			{
				this.kEPHAGKCAGK_ = value;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x002207A1 File Offset: 0x0021E9A1
		// (set) Token: 0x0600CAFC RID: 51964 RVA: 0x002207A9 File Offset: 0x0021E9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x0600CAFD RID: 51965 RVA: 0x002207B2 File Offset: 0x0021E9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartPunkLordRaidScRsp);
		}

		// Token: 0x0600CAFE RID: 51966 RVA: 0x002207C0 File Offset: 0x0021E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartPunkLordRaidScRsp other)
		{
			return other != null && (other == this || (this.fDDFAKGGPGF_.Equals(other.fDDFAKGGPGF_) && this.Retcode == other.Retcode && this.EBBHDIDOOKI == other.EBBHDIDOOKI && object.Equals(this.IOEBEBCENHO, other.IOEBEBCENHO) && this.KEPHAGKCAGK == other.KEPHAGKCAGK && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x00220858 File Offset: 0x0021EA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fDDFAKGGPGF_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EBBHDIDOOKI != 0L)
			{
				num ^= this.EBBHDIDOOKI.GetHashCode();
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num ^= this.IOEBEBCENHO.GetHashCode();
			}
			if (this.KEPHAGKCAGK)
			{
				num ^= this.KEPHAGKCAGK.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x00220903 File Offset: 0x0021EB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x0022090B File Offset: 0x0021EB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x00220914 File Offset: 0x0021EB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EBBHDIDOOKI != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EBBHDIDOOKI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.iOEBEBCENHO_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.IOEBEBCENHO);
			}
			this.fDDFAKGGPGF_.WriteTo(ref output, StartPunkLordRaidScRsp._repeated_fDDFAKGGPGF_codec);
			if (this.scene_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Scene);
			}
			if (this.KEPHAGKCAGK)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.KEPHAGKCAGK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x002209D4 File Offset: 0x0021EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fDDFAKGGPGF_.CalculateSize(StartPunkLordRaidScRsp._repeated_fDDFAKGGPGF_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EBBHDIDOOKI != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EBBHDIDOOKI);
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IOEBEBCENHO);
			}
			if (this.KEPHAGKCAGK)
			{
				num += 2;
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x00220A7C File Offset: 0x0021EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartPunkLordRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.fDDFAKGGPGF_.Add(other.fDDFAKGGPGF_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EBBHDIDOOKI != 0L)
			{
				this.EBBHDIDOOKI = other.EBBHDIDOOKI;
			}
			if (other.iOEBEBCENHO_ != null)
			{
				if (this.iOEBEBCENHO_ == null)
				{
					this.IOEBEBCENHO = new MGLAPEBCMOO();
				}
				this.IOEBEBCENHO.MergeFrom(other.IOEBEBCENHO);
			}
			if (other.KEPHAGKCAGK)
			{
				this.KEPHAGKCAGK = other.KEPHAGKCAGK;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new OIIOLCPBLCF();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x00220B49 File Offset: 0x0021ED49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB06 RID: 51974 RVA: 0x00220B54 File Offset: 0x0021ED54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.EBBHDIDOOKI = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.iOEBEBCENHO_ == null)
						{
							this.IOEBEBCENHO = new MGLAPEBCMOO();
						}
						input.ReadMessage(this.IOEBEBCENHO);
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.fDDFAKGGPGF_.AddEntriesFrom(ref input, StartPunkLordRaidScRsp._repeated_fDDFAKGGPGF_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new OIIOLCPBLCF();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
					if (num == 72U)
					{
						this.KEPHAGKCAGK = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051D2 RID: 20946
		private static readonly MessageParser<StartPunkLordRaidScRsp> _parser = new MessageParser<StartPunkLordRaidScRsp>(() => new StartPunkLordRaidScRsp());

		// Token: 0x040051D3 RID: 20947
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051D4 RID: 20948
		public const int FDDFAKGGPGFFieldNumber = 5;

		// Token: 0x040051D5 RID: 20949
		private static readonly FieldCodec<uint> _repeated_fDDFAKGGPGF_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040051D6 RID: 20950
		private readonly RepeatedField<uint> fDDFAKGGPGF_ = new RepeatedField<uint>();

		// Token: 0x040051D7 RID: 20951
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040051D8 RID: 20952
		private uint retcode_;

		// Token: 0x040051D9 RID: 20953
		public const int EBBHDIDOOKIFieldNumber = 1;

		// Token: 0x040051DA RID: 20954
		private long eBBHDIDOOKI_;

		// Token: 0x040051DB RID: 20955
		public const int IOEBEBCENHOFieldNumber = 4;

		// Token: 0x040051DC RID: 20956
		private MGLAPEBCMOO iOEBEBCENHO_;

		// Token: 0x040051DD RID: 20957
		public const int KEPHAGKCAGKFieldNumber = 9;

		// Token: 0x040051DE RID: 20958
		private bool kEPHAGKCAGK_;

		// Token: 0x040051DF RID: 20959
		public const int SceneFieldNumber = 8;

		// Token: 0x040051E0 RID: 20960
		private OIIOLCPBLCF scene_;
	}
}
