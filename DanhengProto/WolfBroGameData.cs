using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001423 RID: 5155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameData : IMessage<WolfBroGameData>, IMessage, IEquatable<WolfBroGameData>, IDeepCloneable<WolfBroGameData>, IBufferMessage
	{
		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x0026345B File Offset: 0x0026165B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameData> Parser
		{
			get
			{
				return WolfBroGameData._parser;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x00263462 File Offset: 0x00261662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x00263474 File Offset: 0x00261674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameData.Descriptor;
			}
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x0026347B File Offset: 0x0026167B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData()
		{
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x0026349C File Offset: 0x0026169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData(WolfBroGameData other) : this()
		{
			this.jBOFIALLOPI_ = other.jBOFIALLOPI_.Clone();
			this.kPPEHBJLAAA_ = ((other.kPPEHBJLAAA_ != null) ? other.kPPEHBJLAAA_.Clone() : null);
			this.id_ = other.id_;
			this.pPINPEHJFAB_ = other.pPINPEHJFAB_;
			this.nIEPAOBBFJF_ = other.nIEPAOBBFJF_;
			this.hFNEKMMMFHO_ = other.hFNEKMMMFHO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5FD RID: 58877 RVA: 0x0026351D File Offset: 0x0026171D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData Clone()
		{
			return new WolfBroGameData(this);
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x00263525 File Offset: 0x00261725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> JBOFIALLOPI
		{
			get
			{
				return this.jBOFIALLOPI_;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x0026352D File Offset: 0x0026172D
		// (set) Token: 0x0600E600 RID: 58880 RVA: 0x00263535 File Offset: 0x00261735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameInfo KPPEHBJLAAA
		{
			get
			{
				return this.kPPEHBJLAAA_;
			}
			set
			{
				this.kPPEHBJLAAA_ = value;
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x0600E601 RID: 58881 RVA: 0x0026353E File Offset: 0x0026173E
		// (set) Token: 0x0600E602 RID: 58882 RVA: 0x00263546 File Offset: 0x00261746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x0600E603 RID: 58883 RVA: 0x0026354F File Offset: 0x0026174F
		// (set) Token: 0x0600E604 RID: 58884 RVA: 0x00263557 File Offset: 0x00261757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPINPEHJFAB
		{
			get
			{
				return this.pPINPEHJFAB_;
			}
			set
			{
				this.pPINPEHJFAB_ = value;
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x00263560 File Offset: 0x00261760
		// (set) Token: 0x0600E606 RID: 58886 RVA: 0x00263568 File Offset: 0x00261768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NIEPAOBBFJF
		{
			get
			{
				return this.nIEPAOBBFJF_;
			}
			set
			{
				this.nIEPAOBBFJF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x0600E607 RID: 58887 RVA: 0x0026357B File Offset: 0x0026177B
		// (set) Token: 0x0600E608 RID: 58888 RVA: 0x00263583 File Offset: 0x00261783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HFNEKMMMFHO
		{
			get
			{
				return this.hFNEKMMMFHO_;
			}
			set
			{
				this.hFNEKMMMFHO_ = value;
			}
		}

		// Token: 0x0600E609 RID: 58889 RVA: 0x0026358C File Offset: 0x0026178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameData);
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x0026359C File Offset: 0x0026179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameData other)
		{
			return other != null && (other == this || (this.jBOFIALLOPI_.Equals(other.jBOFIALLOPI_) && object.Equals(this.KPPEHBJLAAA, other.KPPEHBJLAAA) && this.Id == other.Id && this.PPINPEHJFAB == other.PPINPEHJFAB && !(this.NIEPAOBBFJF != other.NIEPAOBBFJF) && this.HFNEKMMMFHO == other.HFNEKMMMFHO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E60B RID: 58891 RVA: 0x00263634 File Offset: 0x00261834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jBOFIALLOPI_.GetHashCode();
			if (this.kPPEHBJLAAA_ != null)
			{
				num ^= this.KPPEHBJLAAA.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PPINPEHJFAB != 0U)
			{
				num ^= this.PPINPEHJFAB.GetHashCode();
			}
			if (this.NIEPAOBBFJF.Length != 0)
			{
				num ^= this.NIEPAOBBFJF.GetHashCode();
			}
			if (this.HFNEKMMMFHO)
			{
				num ^= this.HFNEKMMMFHO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E60C RID: 58892 RVA: 0x002636E4 File Offset: 0x002618E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E60D RID: 58893 RVA: 0x002636EC File Offset: 0x002618EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E60E RID: 58894 RVA: 0x002636F8 File Offset: 0x002618F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PPINPEHJFAB != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PPINPEHJFAB);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			if (this.kPPEHBJLAAA_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.KPPEHBJLAAA);
			}
			if (this.HFNEKMMMFHO)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.HFNEKMMMFHO);
			}
			this.jBOFIALLOPI_.WriteTo(ref output, WolfBroGameData._repeated_jBOFIALLOPI_codec);
			if (this.NIEPAOBBFJF.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.NIEPAOBBFJF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E60F RID: 58895 RVA: 0x002637BC File Offset: 0x002619BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jBOFIALLOPI_.CalculateSize(WolfBroGameData._repeated_jBOFIALLOPI_codec);
			if (this.kPPEHBJLAAA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KPPEHBJLAAA);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.PPINPEHJFAB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPINPEHJFAB);
			}
			if (this.NIEPAOBBFJF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NIEPAOBBFJF);
			}
			if (this.HFNEKMMMFHO)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E610 RID: 58896 RVA: 0x00263868 File Offset: 0x00261A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameData other)
		{
			if (other == null)
			{
				return;
			}
			this.jBOFIALLOPI_.Add(other.jBOFIALLOPI_);
			if (other.kPPEHBJLAAA_ != null)
			{
				if (this.kPPEHBJLAAA_ == null)
				{
					this.KPPEHBJLAAA = new WolfBroGameInfo();
				}
				this.KPPEHBJLAAA.MergeFrom(other.KPPEHBJLAAA);
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.PPINPEHJFAB != 0U)
			{
				this.PPINPEHJFAB = other.PPINPEHJFAB;
			}
			if (other.NIEPAOBBFJF.Length != 0)
			{
				this.NIEPAOBBFJF = other.NIEPAOBBFJF;
			}
			if (other.HFNEKMMMFHO)
			{
				this.HFNEKMMMFHO = other.HFNEKMMMFHO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E611 RID: 58897 RVA: 0x00263922 File Offset: 0x00261B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E612 RID: 58898 RVA: 0x0026392C File Offset: 0x00261B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 8U)
					{
						this.PPINPEHJFAB = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.kPPEHBJLAAA_ == null)
						{
							this.KPPEHBJLAAA = new WolfBroGameInfo();
						}
						input.ReadMessage(this.KPPEHBJLAAA);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HFNEKMMMFHO = input.ReadBool();
						continue;
					}
					if (num == 82U)
					{
						this.jBOFIALLOPI_.AddEntriesFrom(ref input, WolfBroGameData._repeated_jBOFIALLOPI_codec);
						continue;
					}
					if (num == 122U)
					{
						this.NIEPAOBBFJF = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B4A RID: 23370
		private static readonly MessageParser<WolfBroGameData> _parser = new MessageParser<WolfBroGameData>(() => new WolfBroGameData());

		// Token: 0x04005B4B RID: 23371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B4C RID: 23372
		public const int JBOFIALLOPIFieldNumber = 10;

		// Token: 0x04005B4D RID: 23373
		private static readonly FieldCodec<Vector> _repeated_jBOFIALLOPI_codec = FieldCodec.ForMessage<Vector>(82U, Vector.Parser);

		// Token: 0x04005B4E RID: 23374
		private readonly RepeatedField<Vector> jBOFIALLOPI_ = new RepeatedField<Vector>();

		// Token: 0x04005B4F RID: 23375
		public const int KPPEHBJLAAAFieldNumber = 6;

		// Token: 0x04005B50 RID: 23376
		private WolfBroGameInfo kPPEHBJLAAA_;

		// Token: 0x04005B51 RID: 23377
		public const int IdFieldNumber = 4;

		// Token: 0x04005B52 RID: 23378
		private uint id_;

		// Token: 0x04005B53 RID: 23379
		public const int PPINPEHJFABFieldNumber = 1;

		// Token: 0x04005B54 RID: 23380
		private uint pPINPEHJFAB_;

		// Token: 0x04005B55 RID: 23381
		public const int NIEPAOBBFJFFieldNumber = 15;

		// Token: 0x04005B56 RID: 23382
		private string nIEPAOBBFJF_ = "";

		// Token: 0x04005B57 RID: 23383
		public const int HFNEKMMMFHOFieldNumber = 9;

		// Token: 0x04005B58 RID: 23384
		private bool hFNEKMMMFHO_;
	}
}
