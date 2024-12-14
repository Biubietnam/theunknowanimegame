using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000181 RID: 385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellMonsterSelectInfo : IMessage<CellMonsterSelectInfo>, IMessage, IEquatable<CellMonsterSelectInfo>, IDeepCloneable<CellMonsterSelectInfo>, IBufferMessage
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00031A11 File Offset: 0x0002FC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellMonsterSelectInfo> Parser
		{
			get
			{
				return CellMonsterSelectInfo._parser;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00031A18 File Offset: 0x0002FC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellMonsterSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00031A2A File Offset: 0x0002FC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellMonsterSelectInfo.Descriptor;
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00031A31 File Offset: 0x0002FC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterSelectInfo()
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00031A4F File Offset: 0x0002FC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterSelectInfo(CellMonsterSelectInfo other) : this()
		{
			this.selectDecayId_ = other.selectDecayId_.Clone();
			this.mazeBuffList_ = other.mazeBuffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00031A8A File Offset: 0x0002FC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterSelectInfo Clone()
		{
			return new CellMonsterSelectInfo(this);
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00031A92 File Offset: 0x0002FC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SelectDecayId
		{
			get
			{
				return this.selectDecayId_;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00031A9A File Offset: 0x0002FC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MazeBuffList
		{
			get
			{
				return this.mazeBuffList_;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00031AA2 File Offset: 0x0002FCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellMonsterSelectInfo);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00031AB0 File Offset: 0x0002FCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellMonsterSelectInfo other)
		{
			return other != null && (other == this || (this.selectDecayId_.Equals(other.selectDecayId_) && this.mazeBuffList_.Equals(other.mazeBuffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00031B04 File Offset: 0x0002FD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectDecayId_.GetHashCode();
			num ^= this.mazeBuffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00031B46 File Offset: 0x0002FD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00031B4E File Offset: 0x0002FD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00031B57 File Offset: 0x0002FD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mazeBuffList_.WriteTo(ref output, CellMonsterSelectInfo._repeated_mazeBuffList_codec);
			this.selectDecayId_.WriteTo(ref output, CellMonsterSelectInfo._repeated_selectDecayId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00031B90 File Offset: 0x0002FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectDecayId_.CalculateSize(CellMonsterSelectInfo._repeated_selectDecayId_codec);
			num += this.mazeBuffList_.CalculateSize(CellMonsterSelectInfo._repeated_mazeBuffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00031BDC File Offset: 0x0002FDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellMonsterSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectDecayId_.Add(other.selectDecayId_);
			this.mazeBuffList_.Add(other.mazeBuffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00031C1B File Offset: 0x0002FE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00031C24 File Offset: 0x0002FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.mazeBuffList_.AddEntriesFrom(ref input, CellMonsterSelectInfo._repeated_mazeBuffList_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.selectDecayId_.AddEntriesFrom(ref input, CellMonsterSelectInfo._repeated_selectDecayId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000730 RID: 1840
		private static readonly MessageParser<CellMonsterSelectInfo> _parser = new MessageParser<CellMonsterSelectInfo>(() => new CellMonsterSelectInfo());

		// Token: 0x04000731 RID: 1841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000732 RID: 1842
		public const int SelectDecayIdFieldNumber = 11;

		// Token: 0x04000733 RID: 1843
		private static readonly FieldCodec<uint> _repeated_selectDecayId_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04000734 RID: 1844
		private readonly RepeatedField<uint> selectDecayId_ = new RepeatedField<uint>();

		// Token: 0x04000735 RID: 1845
		public const int MazeBuffListFieldNumber = 10;

		// Token: 0x04000736 RID: 1846
		private static readonly FieldCodec<uint> _repeated_mazeBuffList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04000737 RID: 1847
		private readonly RepeatedField<uint> mazeBuffList_ = new RepeatedField<uint>();
	}
}
