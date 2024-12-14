using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200142B RID: 5163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameInfo : IMessage<WolfBroGameInfo>, IMessage, IEquatable<WolfBroGameInfo>, IDeepCloneable<WolfBroGameInfo>, IBufferMessage
	{
		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x0026427F File Offset: 0x0026247F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameInfo> Parser
		{
			get
			{
				return WolfBroGameInfo._parser;
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0600E655 RID: 58965 RVA: 0x00264286 File Offset: 0x00262486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0600E656 RID: 58966 RVA: 0x00264298 File Offset: 0x00262498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameInfo.Descriptor;
			}
		}

		// Token: 0x0600E657 RID: 58967 RVA: 0x0026429F File Offset: 0x0026249F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameInfo()
		{
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x002642B4 File Offset: 0x002624B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameInfo(WolfBroGameInfo other) : this()
		{
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.pPINPEHJFAB_ = other.pPINPEHJFAB_;
			this.jBOFIALLOPI_ = other.jBOFIALLOPI_.Clone();
			this.hFNEKMMMFHO_ = other.hFNEKMMMFHO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E659 RID: 58969 RVA: 0x0026431D File Offset: 0x0026251D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameInfo Clone()
		{
			return new WolfBroGameInfo(this);
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x00264325 File Offset: 0x00262525
		// (set) Token: 0x0600E65B RID: 58971 RVA: 0x0026432D File Offset: 0x0026252D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x0600E65C RID: 58972 RVA: 0x00264336 File Offset: 0x00262536
		// (set) Token: 0x0600E65D RID: 58973 RVA: 0x0026433E File Offset: 0x0026253E
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

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0600E65E RID: 58974 RVA: 0x00264347 File Offset: 0x00262547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> JBOFIALLOPI
		{
			get
			{
				return this.jBOFIALLOPI_;
			}
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x0600E65F RID: 58975 RVA: 0x0026434F File Offset: 0x0026254F
		// (set) Token: 0x0600E660 RID: 58976 RVA: 0x00264357 File Offset: 0x00262557
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

		// Token: 0x0600E661 RID: 58977 RVA: 0x00264360 File Offset: 0x00262560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameInfo);
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x00264370 File Offset: 0x00262570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Motion, other.Motion) && this.PPINPEHJFAB == other.PPINPEHJFAB && this.jBOFIALLOPI_.Equals(other.jBOFIALLOPI_) && this.HFNEKMMMFHO == other.HFNEKMMMFHO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E663 RID: 58979 RVA: 0x002643E4 File Offset: 0x002625E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.PPINPEHJFAB != 0U)
			{
				num ^= this.PPINPEHJFAB.GetHashCode();
			}
			num ^= this.jBOFIALLOPI_.GetHashCode();
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

		// Token: 0x0600E664 RID: 58980 RVA: 0x00264460 File Offset: 0x00262660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x00264468 File Offset: 0x00262668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E666 RID: 58982 RVA: 0x00264474 File Offset: 0x00262674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jBOFIALLOPI_.WriteTo(ref output, WolfBroGameInfo._repeated_jBOFIALLOPI_codec);
			if (this.HFNEKMMMFHO)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.HFNEKMMMFHO);
			}
			if (this.PPINPEHJFAB != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PPINPEHJFAB);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E667 RID: 58983 RVA: 0x002644FC File Offset: 0x002626FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.PPINPEHJFAB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPINPEHJFAB);
			}
			num += this.jBOFIALLOPI_.CalculateSize(WolfBroGameInfo._repeated_jBOFIALLOPI_codec);
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

		// Token: 0x0600E668 RID: 58984 RVA: 0x00264574 File Offset: 0x00262774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.PPINPEHJFAB != 0U)
			{
				this.PPINPEHJFAB = other.PPINPEHJFAB;
			}
			this.jBOFIALLOPI_.Add(other.jBOFIALLOPI_);
			if (other.HFNEKMMMFHO)
			{
				this.HFNEKMMMFHO = other.HFNEKMMMFHO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E669 RID: 58985 RVA: 0x00264601 File Offset: 0x00262801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x0026460C File Offset: 0x0026280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 34U)
					{
						this.jBOFIALLOPI_.AddEntriesFrom(ref input, WolfBroGameInfo._repeated_jBOFIALLOPI_codec);
						continue;
					}
					if (num == 48U)
					{
						this.HFNEKMMMFHO = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.PPINPEHJFAB = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B6A RID: 23402
		private static readonly MessageParser<WolfBroGameInfo> _parser = new MessageParser<WolfBroGameInfo>(() => new WolfBroGameInfo());

		// Token: 0x04005B6B RID: 23403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B6C RID: 23404
		public const int MotionFieldNumber = 15;

		// Token: 0x04005B6D RID: 23405
		private MotionInfo motion_;

		// Token: 0x04005B6E RID: 23406
		public const int PPINPEHJFABFieldNumber = 8;

		// Token: 0x04005B6F RID: 23407
		private uint pPINPEHJFAB_;

		// Token: 0x04005B70 RID: 23408
		public const int JBOFIALLOPIFieldNumber = 4;

		// Token: 0x04005B71 RID: 23409
		private static readonly FieldCodec<Vector> _repeated_jBOFIALLOPI_codec = FieldCodec.ForMessage<Vector>(34U, Vector.Parser);

		// Token: 0x04005B72 RID: 23410
		private readonly RepeatedField<Vector> jBOFIALLOPI_ = new RepeatedField<Vector>();

		// Token: 0x04005B73 RID: 23411
		public const int HFNEKMMMFHOFieldNumber = 6;

		// Token: 0x04005B74 RID: 23412
		private bool hFNEKMMMFHO_;
	}
}
