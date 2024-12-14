using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200116D RID: 4461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooMutateScRsp : IMessage<SpaceZooMutateScRsp>, IMessage, IEquatable<SpaceZooMutateScRsp>, IDeepCloneable<SpaceZooMutateScRsp>, IBufferMessage
	{
		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600C705 RID: 50949 RVA: 0x0021625F File Offset: 0x0021445F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooMutateScRsp> Parser
		{
			get
			{
				return SpaceZooMutateScRsp._parser;
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600C706 RID: 50950 RVA: 0x00216266 File Offset: 0x00214466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooMutateScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600C707 RID: 50951 RVA: 0x00216278 File Offset: 0x00214478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooMutateScRsp.Descriptor;
			}
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x0021627F File Offset: 0x0021447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateScRsp()
		{
		}

		// Token: 0x0600C709 RID: 50953 RVA: 0x00216294 File Offset: 0x00214494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateScRsp(SpaceZooMutateScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dFJCDDIHOGM_ = other.dFJCDDIHOGM_.Clone();
			this.cHGLLNLBJIL_ = ((other.cHGLLNLBJIL_ != null) ? other.cHGLLNLBJIL_.Clone() : null);
			this.iFCOOAAPLDF_ = other.iFCOOAAPLDF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x002162FD File Offset: 0x002144FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateScRsp Clone()
		{
			return new SpaceZooMutateScRsp(this);
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600C70B RID: 50955 RVA: 0x00216305 File Offset: 0x00214505
		// (set) Token: 0x0600C70C RID: 50956 RVA: 0x0021630D File Offset: 0x0021450D
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

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600C70D RID: 50957 RVA: 0x00216316 File Offset: 0x00214516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MPPOJKLLOHA> DFJCDDIHOGM
		{
			get
			{
				return this.dFJCDDIHOGM_;
			}
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600C70E RID: 50958 RVA: 0x0021631E File Offset: 0x0021451E
		// (set) Token: 0x0600C70F RID: 50959 RVA: 0x00216326 File Offset: 0x00214526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CHBBGEIDOGB CHGLLNLBJIL
		{
			get
			{
				return this.cHGLLNLBJIL_;
			}
			set
			{
				this.cHGLLNLBJIL_ = value;
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600C710 RID: 50960 RVA: 0x0021632F File Offset: 0x0021452F
		// (set) Token: 0x0600C711 RID: 50961 RVA: 0x00216337 File Offset: 0x00214537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IFCOOAAPLDF
		{
			get
			{
				return this.iFCOOAAPLDF_;
			}
			set
			{
				this.iFCOOAAPLDF_ = value;
			}
		}

		// Token: 0x0600C712 RID: 50962 RVA: 0x00216340 File Offset: 0x00214540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooMutateScRsp);
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x00216350 File Offset: 0x00214550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooMutateScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.dFJCDDIHOGM_.Equals(other.dFJCDDIHOGM_) && object.Equals(this.CHGLLNLBJIL, other.CHGLLNLBJIL) && this.IFCOOAAPLDF == other.IFCOOAAPLDF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x002163C4 File Offset: 0x002145C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dFJCDDIHOGM_.GetHashCode();
			if (this.cHGLLNLBJIL_ != null)
			{
				num ^= this.CHGLLNLBJIL.GetHashCode();
			}
			if (this.IFCOOAAPLDF)
			{
				num ^= this.IFCOOAAPLDF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x00216440 File Offset: 0x00214640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x00216448 File Offset: 0x00214648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x00216454 File Offset: 0x00214654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IFCOOAAPLDF)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IFCOOAAPLDF);
			}
			if (this.cHGLLNLBJIL_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CHGLLNLBJIL);
			}
			this.dFJCDDIHOGM_.WriteTo(ref output, SpaceZooMutateScRsp._repeated_dFJCDDIHOGM_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x002164DC File Offset: 0x002146DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dFJCDDIHOGM_.CalculateSize(SpaceZooMutateScRsp._repeated_dFJCDDIHOGM_codec);
			if (this.cHGLLNLBJIL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CHGLLNLBJIL);
			}
			if (this.IFCOOAAPLDF)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x00216554 File Offset: 0x00214754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooMutateScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dFJCDDIHOGM_.Add(other.dFJCDDIHOGM_);
			if (other.cHGLLNLBJIL_ != null)
			{
				if (this.cHGLLNLBJIL_ == null)
				{
					this.CHGLLNLBJIL = new CHBBGEIDOGB();
				}
				this.CHGLLNLBJIL.MergeFrom(other.CHGLLNLBJIL);
			}
			if (other.IFCOOAAPLDF)
			{
				this.IFCOOAAPLDF = other.IFCOOAAPLDF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C71A RID: 50970 RVA: 0x002165E1 File Offset: 0x002147E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x002165EC File Offset: 0x002147EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 8U)
					{
						this.IFCOOAAPLDF = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						if (this.cHGLLNLBJIL_ == null)
						{
							this.CHGLLNLBJIL = new CHBBGEIDOGB();
						}
						input.ReadMessage(this.CHGLLNLBJIL);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.dFJCDDIHOGM_.AddEntriesFrom(ref input, SpaceZooMutateScRsp._repeated_dFJCDDIHOGM_codec);
						continue;
					}
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005067 RID: 20583
		private static readonly MessageParser<SpaceZooMutateScRsp> _parser = new MessageParser<SpaceZooMutateScRsp>(() => new SpaceZooMutateScRsp());

		// Token: 0x04005068 RID: 20584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005069 RID: 20585
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400506A RID: 20586
		private uint retcode_;

		// Token: 0x0400506B RID: 20587
		public const int DFJCDDIHOGMFieldNumber = 6;

		// Token: 0x0400506C RID: 20588
		private static readonly FieldCodec<MPPOJKLLOHA> _repeated_dFJCDDIHOGM_codec = FieldCodec.ForMessage<MPPOJKLLOHA>(50U, MPPOJKLLOHA.Parser);

		// Token: 0x0400506D RID: 20589
		private readonly RepeatedField<MPPOJKLLOHA> dFJCDDIHOGM_ = new RepeatedField<MPPOJKLLOHA>();

		// Token: 0x0400506E RID: 20590
		public const int CHGLLNLBJILFieldNumber = 5;

		// Token: 0x0400506F RID: 20591
		private CHBBGEIDOGB cHGLLNLBJIL_;

		// Token: 0x04005070 RID: 20592
		public const int IFCOOAAPLDFFieldNumber = 1;

		// Token: 0x04005071 RID: 20593
		private bool iFCOOAAPLDF_;
	}
}
