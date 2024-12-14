using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B91 RID: 2961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterPhaseStt : IMessage<MonsterPhaseStt>, IMessage, IEquatable<MonsterPhaseStt>, IDeepCloneable<MonsterPhaseStt>, IBufferMessage
	{
		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600832D RID: 33581 RVA: 0x0015A375 File Offset: 0x00158575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterPhaseStt> Parser
		{
			get
			{
				return MonsterPhaseStt._parser;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600832E RID: 33582 RVA: 0x0015A37C File Offset: 0x0015857C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonsterPhaseSttReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600832F RID: 33583 RVA: 0x0015A38E File Offset: 0x0015858E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterPhaseStt.Descriptor;
			}
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0015A395 File Offset: 0x00158595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPhaseStt()
		{
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x0015A3A0 File Offset: 0x001585A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPhaseStt(MonsterPhaseStt other) : this()
		{
			this.nAGBMPFECGG_ = other.nAGBMPFECGG_;
			this.iGIGNNAFOHO_ = other.iGIGNNAFOHO_;
			this.mBCLNKPADAF_ = other.mBCLNKPADAF_;
			this.breakTimes_ = other.breakTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0015A3F4 File Offset: 0x001585F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPhaseStt Clone()
		{
			return new MonsterPhaseStt(this);
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06008333 RID: 33587 RVA: 0x0015A3FC File Offset: 0x001585FC
		// (set) Token: 0x06008334 RID: 33588 RVA: 0x0015A404 File Offset: 0x00158604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NAGBMPFECGG
		{
			get
			{
				return this.nAGBMPFECGG_;
			}
			set
			{
				this.nAGBMPFECGG_ = value;
			}
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06008335 RID: 33589 RVA: 0x0015A40D File Offset: 0x0015860D
		// (set) Token: 0x06008336 RID: 33590 RVA: 0x0015A415 File Offset: 0x00158615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double IGIGNNAFOHO
		{
			get
			{
				return this.iGIGNNAFOHO_;
			}
			set
			{
				this.iGIGNNAFOHO_ = value;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x06008337 RID: 33591 RVA: 0x0015A41E File Offset: 0x0015861E
		// (set) Token: 0x06008338 RID: 33592 RVA: 0x0015A426 File Offset: 0x00158626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBCLNKPADAF
		{
			get
			{
				return this.mBCLNKPADAF_;
			}
			set
			{
				this.mBCLNKPADAF_ = value;
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06008339 RID: 33593 RVA: 0x0015A42F File Offset: 0x0015862F
		// (set) Token: 0x0600833A RID: 33594 RVA: 0x0015A437 File Offset: 0x00158637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BreakTimes
		{
			get
			{
				return this.breakTimes_;
			}
			set
			{
				this.breakTimes_ = value;
			}
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x0015A440 File Offset: 0x00158640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterPhaseStt);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x0015A450 File Offset: 0x00158650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterPhaseStt other)
		{
			return other != null && (other == this || (this.NAGBMPFECGG == other.NAGBMPFECGG && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.IGIGNNAFOHO, other.IGIGNNAFOHO) && this.MBCLNKPADAF == other.MBCLNKPADAF && this.BreakTimes == other.BreakTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x0015A4C4 File Offset: 0x001586C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NAGBMPFECGG != 0U)
			{
				num ^= this.NAGBMPFECGG.GetHashCode();
			}
			if (this.IGIGNNAFOHO != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.IGIGNNAFOHO);
			}
			if (this.MBCLNKPADAF != 0U)
			{
				num ^= this.MBCLNKPADAF.GetHashCode();
			}
			if (this.BreakTimes != 0U)
			{
				num ^= this.BreakTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0015A559 File Offset: 0x00158759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0015A561 File Offset: 0x00158761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0015A56C File Offset: 0x0015876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NAGBMPFECGG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NAGBMPFECGG);
			}
			if (this.IGIGNNAFOHO != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.IGIGNNAFOHO);
			}
			if (this.MBCLNKPADAF != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MBCLNKPADAF);
			}
			if (this.BreakTimes != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BreakTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0015A608 File Offset: 0x00158808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NAGBMPFECGG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NAGBMPFECGG);
			}
			if (this.IGIGNNAFOHO != 0.0)
			{
				num += 9;
			}
			if (this.MBCLNKPADAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBCLNKPADAF);
			}
			if (this.BreakTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BreakTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0015A68C File Offset: 0x0015888C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterPhaseStt other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NAGBMPFECGG != 0U)
			{
				this.NAGBMPFECGG = other.NAGBMPFECGG;
			}
			if (other.IGIGNNAFOHO != 0.0)
			{
				this.IGIGNNAFOHO = other.IGIGNNAFOHO;
			}
			if (other.MBCLNKPADAF != 0U)
			{
				this.MBCLNKPADAF = other.MBCLNKPADAF;
			}
			if (other.BreakTimes != 0U)
			{
				this.BreakTimes = other.BreakTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0015A70D File Offset: 0x0015890D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x0015A718 File Offset: 0x00158918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 17U)
				{
					if (num == 8U)
					{
						this.NAGBMPFECGG = input.ReadUInt32();
						continue;
					}
					if (num == 17U)
					{
						this.IGIGNNAFOHO = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MBCLNKPADAF = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BreakTimes = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400322B RID: 12843
		private static readonly MessageParser<MonsterPhaseStt> _parser = new MessageParser<MonsterPhaseStt>(() => new MonsterPhaseStt());

		// Token: 0x0400322C RID: 12844
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400322D RID: 12845
		public const int NAGBMPFECGGFieldNumber = 1;

		// Token: 0x0400322E RID: 12846
		private uint nAGBMPFECGG_;

		// Token: 0x0400322F RID: 12847
		public const int IGIGNNAFOHOFieldNumber = 2;

		// Token: 0x04003230 RID: 12848
		private double iGIGNNAFOHO_;

		// Token: 0x04003231 RID: 12849
		public const int MBCLNKPADAFFieldNumber = 3;

		// Token: 0x04003232 RID: 12850
		private uint mBCLNKPADAF_;

		// Token: 0x04003233 RID: 12851
		public const int BreakTimesFieldNumber = 4;

		// Token: 0x04003234 RID: 12852
		private uint breakTimes_;
	}
}
