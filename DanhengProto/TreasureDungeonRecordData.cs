using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200139D RID: 5021
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonRecordData : IMessage<TreasureDungeonRecordData>, IMessage, IEquatable<TreasureDungeonRecordData>, IDeepCloneable<TreasureDungeonRecordData>, IBufferMessage
	{
		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x0025509B File Offset: 0x0025329B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonRecordData> Parser
		{
			get
			{
				return TreasureDungeonRecordData._parser;
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x002550A2 File Offset: 0x002532A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonRecordDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x002550B4 File Offset: 0x002532B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonRecordData.Descriptor;
			}
		}

		// Token: 0x0600E031 RID: 57393 RVA: 0x002550BB File Offset: 0x002532BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonRecordData()
		{
		}

		// Token: 0x0600E032 RID: 57394 RVA: 0x002550C4 File Offset: 0x002532C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonRecordData(TreasureDungeonRecordData other) : this()
		{
			this.param1_ = other.param1_;
			this.sourceGridId_ = other.sourceGridId_;
			this.targetGridId_ = other.targetGridId_;
			this.param2_ = other.param2_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x00255124 File Offset: 0x00253324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonRecordData Clone()
		{
			return new TreasureDungeonRecordData(this);
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x0600E034 RID: 57396 RVA: 0x0025512C File Offset: 0x0025332C
		// (set) Token: 0x0600E035 RID: 57397 RVA: 0x00255134 File Offset: 0x00253334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Param1
		{
			get
			{
				return this.param1_;
			}
			set
			{
				this.param1_ = value;
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0600E036 RID: 57398 RVA: 0x0025513D File Offset: 0x0025333D
		// (set) Token: 0x0600E037 RID: 57399 RVA: 0x00255145 File Offset: 0x00253345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SourceGridId
		{
			get
			{
				return this.sourceGridId_;
			}
			set
			{
				this.sourceGridId_ = value;
			}
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0600E038 RID: 57400 RVA: 0x0025514E File Offset: 0x0025334E
		// (set) Token: 0x0600E039 RID: 57401 RVA: 0x00255156 File Offset: 0x00253356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetGridId
		{
			get
			{
				return this.targetGridId_;
			}
			set
			{
				this.targetGridId_ = value;
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x0025515F File Offset: 0x0025335F
		// (set) Token: 0x0600E03B RID: 57403 RVA: 0x00255167 File Offset: 0x00253367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Param2
		{
			get
			{
				return this.param2_;
			}
			set
			{
				this.param2_ = value;
			}
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0600E03C RID: 57404 RVA: 0x00255170 File Offset: 0x00253370
		// (set) Token: 0x0600E03D RID: 57405 RVA: 0x00255178 File Offset: 0x00253378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonRecordType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600E03E RID: 57406 RVA: 0x00255181 File Offset: 0x00253381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonRecordData);
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x00255190 File Offset: 0x00253390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonRecordData other)
		{
			return other != null && (other == this || (this.Param1 == other.Param1 && this.SourceGridId == other.SourceGridId && this.TargetGridId == other.TargetGridId && this.Param2 == other.Param2 && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x0025520C File Offset: 0x0025340C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Param1 != 0U)
			{
				num ^= this.Param1.GetHashCode();
			}
			if (this.SourceGridId != 0U)
			{
				num ^= this.SourceGridId.GetHashCode();
			}
			if (this.TargetGridId != 0U)
			{
				num ^= this.TargetGridId.GetHashCode();
			}
			if (this.Param2 != 0U)
			{
				num ^= this.Param2.GetHashCode();
			}
			if (this.Type != TreasureDungeonRecordType.TreasureDungeonRecordNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x002552B5 File Offset: 0x002534B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E042 RID: 57410 RVA: 0x002552BD File Offset: 0x002534BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x002552C8 File Offset: 0x002534C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Param2 != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Param2);
			}
			if (this.SourceGridId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SourceGridId);
			}
			if (this.Param1 != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Param1);
			}
			if (this.TargetGridId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TargetGridId);
			}
			if (this.Type != TreasureDungeonRecordType.TreasureDungeonRecordNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E044 RID: 57412 RVA: 0x00255378 File Offset: 0x00253578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Param1 != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Param1);
			}
			if (this.SourceGridId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceGridId);
			}
			if (this.TargetGridId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGridId);
			}
			if (this.Param2 != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Param2);
			}
			if (this.Type != TreasureDungeonRecordType.TreasureDungeonRecordNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x00255418 File Offset: 0x00253618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonRecordData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Param1 != 0U)
			{
				this.Param1 = other.Param1;
			}
			if (other.SourceGridId != 0U)
			{
				this.SourceGridId = other.SourceGridId;
			}
			if (other.TargetGridId != 0U)
			{
				this.TargetGridId = other.TargetGridId;
			}
			if (other.Param2 != 0U)
			{
				this.Param2 = other.Param2;
			}
			if (other.Type != TreasureDungeonRecordType.TreasureDungeonRecordNone)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x002554A4 File Offset: 0x002536A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E047 RID: 57415 RVA: 0x002554B0 File Offset: 0x002536B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.Param2 = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.SourceGridId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Param1 = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.TargetGridId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Type = (TreasureDungeonRecordType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400592E RID: 22830
		private static readonly MessageParser<TreasureDungeonRecordData> _parser = new MessageParser<TreasureDungeonRecordData>(() => new TreasureDungeonRecordData());

		// Token: 0x0400592F RID: 22831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005930 RID: 22832
		public const int Param1FieldNumber = 10;

		// Token: 0x04005931 RID: 22833
		private uint param1_;

		// Token: 0x04005932 RID: 22834
		public const int SourceGridIdFieldNumber = 8;

		// Token: 0x04005933 RID: 22835
		private uint sourceGridId_;

		// Token: 0x04005934 RID: 22836
		public const int TargetGridIdFieldNumber = 11;

		// Token: 0x04005935 RID: 22837
		private uint targetGridId_;

		// Token: 0x04005936 RID: 22838
		public const int Param2FieldNumber = 5;

		// Token: 0x04005937 RID: 22839
		private uint param2_;

		// Token: 0x04005938 RID: 22840
		public const int TypeFieldNumber = 13;

		// Token: 0x04005939 RID: 22841
		private TreasureDungeonRecordType type_;
	}
}
