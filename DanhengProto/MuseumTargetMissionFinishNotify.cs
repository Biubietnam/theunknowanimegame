using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD1 RID: 3025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumTargetMissionFinishNotify : IMessage<MuseumTargetMissionFinishNotify>, IMessage, IEquatable<MuseumTargetMissionFinishNotify>, IDeepCloneable<MuseumTargetMissionFinishNotify>, IBufferMessage
	{
		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x060085D6 RID: 34262 RVA: 0x001614ED File Offset: 0x0015F6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumTargetMissionFinishNotify> Parser
		{
			get
			{
				return MuseumTargetMissionFinishNotify._parser;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x060085D7 RID: 34263 RVA: 0x001614F4 File Offset: 0x0015F6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumTargetMissionFinishNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x060085D8 RID: 34264 RVA: 0x00161506 File Offset: 0x0015F706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumTargetMissionFinishNotify.Descriptor;
			}
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x0016150D File Offset: 0x0015F70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetMissionFinishNotify()
		{
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00161520 File Offset: 0x0015F720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetMissionFinishNotify(MuseumTargetMissionFinishNotify other) : this()
		{
			this.dCHJNNNJCGF_ = other.dCHJNNNJCGF_.Clone();
			this.pHLFJPFKFOF_ = other.pHLFJPFKFOF_;
			this.kHKNAFHGLIF_ = other.kHKNAFHGLIF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x0016156D File Offset: 0x0015F76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetMissionFinishNotify Clone()
		{
			return new MuseumTargetMissionFinishNotify(this);
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x00161575 File Offset: 0x0015F775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DCHJNNNJCGF
		{
			get
			{
				return this.dCHJNNNJCGF_;
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x0016157D File Offset: 0x0015F77D
		// (set) Token: 0x060085DE RID: 34270 RVA: 0x00161585 File Offset: 0x0015F785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHLFJPFKFOF
		{
			get
			{
				return this.pHLFJPFKFOF_;
			}
			set
			{
				this.pHLFJPFKFOF_ = value;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x0016158E File Offset: 0x0015F78E
		// (set) Token: 0x060085E0 RID: 34272 RVA: 0x00161596 File Offset: 0x0015F796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KHKNAFHGLIF
		{
			get
			{
				return this.kHKNAFHGLIF_;
			}
			set
			{
				this.kHKNAFHGLIF_ = value;
			}
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x0016159F File Offset: 0x0015F79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumTargetMissionFinishNotify);
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x001615B0 File Offset: 0x0015F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumTargetMissionFinishNotify other)
		{
			return other != null && (other == this || (this.dCHJNNNJCGF_.Equals(other.dCHJNNNJCGF_) && this.PHLFJPFKFOF == other.PHLFJPFKFOF && this.KHKNAFHGLIF == other.KHKNAFHGLIF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085E3 RID: 34275 RVA: 0x00161610 File Offset: 0x0015F810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dCHJNNNJCGF_.GetHashCode();
			if (this.PHLFJPFKFOF != 0U)
			{
				num ^= this.PHLFJPFKFOF.GetHashCode();
			}
			if (this.KHKNAFHGLIF)
			{
				num ^= this.KHKNAFHGLIF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085E4 RID: 34276 RVA: 0x00161676 File Offset: 0x0015F876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x0016167E File Offset: 0x0015F87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x00161688 File Offset: 0x0015F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dCHJNNNJCGF_.WriteTo(ref output, MuseumTargetMissionFinishNotify._repeated_dCHJNNNJCGF_codec);
			if (this.KHKNAFHGLIF)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.KHKNAFHGLIF);
			}
			if (this.PHLFJPFKFOF != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PHLFJPFKFOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085E7 RID: 34279 RVA: 0x001616F4 File Offset: 0x0015F8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dCHJNNNJCGF_.CalculateSize(MuseumTargetMissionFinishNotify._repeated_dCHJNNNJCGF_codec);
			if (this.PHLFJPFKFOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHLFJPFKFOF);
			}
			if (this.KHKNAFHGLIF)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00161754 File Offset: 0x0015F954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumTargetMissionFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dCHJNNNJCGF_.Add(other.dCHJNNNJCGF_);
			if (other.PHLFJPFKFOF != 0U)
			{
				this.PHLFJPFKFOF = other.PHLFJPFKFOF;
			}
			if (other.KHKNAFHGLIF)
			{
				this.KHKNAFHGLIF = other.KHKNAFHGLIF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x001617B5 File Offset: 0x0015F9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x001617C0 File Offset: 0x0015F9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.dCHJNNNJCGF_.AddEntriesFrom(ref input, MuseumTargetMissionFinishNotify._repeated_dCHJNNNJCGF_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.KHKNAFHGLIF = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PHLFJPFKFOF = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003343 RID: 13123
		private static readonly MessageParser<MuseumTargetMissionFinishNotify> _parser = new MessageParser<MuseumTargetMissionFinishNotify>(() => new MuseumTargetMissionFinishNotify());

		// Token: 0x04003344 RID: 13124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003345 RID: 13125
		public const int DCHJNNNJCGFFieldNumber = 1;

		// Token: 0x04003346 RID: 13126
		private static readonly FieldCodec<uint> _repeated_dCHJNNNJCGF_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003347 RID: 13127
		private readonly RepeatedField<uint> dCHJNNNJCGF_ = new RepeatedField<uint>();

		// Token: 0x04003348 RID: 13128
		public const int PHLFJPFKFOFFieldNumber = 5;

		// Token: 0x04003349 RID: 13129
		private uint pHLFJPFKFOF_;

		// Token: 0x0400334A RID: 13130
		public const int KHKNAFHGLIFFieldNumber = 4;

		// Token: 0x0400334B RID: 13131
		private bool kHKNAFHGLIF_;
	}
}
