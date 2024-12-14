using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017F RID: 383
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellMonsterInfo : IMessage<CellMonsterInfo>, IMessage, IEquatable<CellMonsterInfo>, IDeepCloneable<CellMonsterInfo>, IBufferMessage
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00031623 File Offset: 0x0002F823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellMonsterInfo> Parser
		{
			get
			{
				return CellMonsterInfo._parser;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003162A File Offset: 0x0002F82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellMonsterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0003163C File Offset: 0x0002F83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellMonsterInfo.Descriptor;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00031643 File Offset: 0x0002F843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterInfo()
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00031658 File Offset: 0x0002F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterInfo(CellMonsterInfo other) : this()
		{
			this.selectBossId_ = other.selectBossId_;
			this.cellMonsterList_ = other.cellMonsterList_.Clone();
			this.confirm_ = other.confirm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000316A5 File Offset: 0x0002F8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterInfo Clone()
		{
			return new CellMonsterInfo(this);
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x000316AD File Offset: 0x0002F8AD
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x000316B5 File Offset: 0x0002F8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectBossId
		{
			get
			{
				return this.selectBossId_;
			}
			set
			{
				this.selectBossId_ = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000316BE File Offset: 0x0002F8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CellMonster> CellMonsterList
		{
			get
			{
				return this.cellMonsterList_;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x000316C6 File Offset: 0x0002F8C6
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x000316CE File Offset: 0x0002F8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Confirm
		{
			get
			{
				return this.confirm_;
			}
			set
			{
				this.confirm_ = value;
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000316D7 File Offset: 0x0002F8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellMonsterInfo);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000316E8 File Offset: 0x0002F8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellMonsterInfo other)
		{
			return other != null && (other == this || (this.SelectBossId == other.SelectBossId && this.cellMonsterList_.Equals(other.cellMonsterList_) && this.Confirm == other.Confirm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00031748 File Offset: 0x0002F948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectBossId != 0U)
			{
				num ^= this.SelectBossId.GetHashCode();
			}
			num ^= this.cellMonsterList_.GetHashCode();
			if (this.Confirm)
			{
				num ^= this.Confirm.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000317AE File Offset: 0x0002F9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000317B6 File Offset: 0x0002F9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000317C0 File Offset: 0x0002F9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cellMonsterList_.WriteTo(ref output, CellMonsterInfo._repeated_cellMonsterList_codec);
			if (this.SelectBossId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SelectBossId);
			}
			if (this.Confirm)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Confirm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0003182C File Offset: 0x0002FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectBossId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectBossId);
			}
			num += this.cellMonsterList_.CalculateSize(CellMonsterInfo._repeated_cellMonsterList_codec);
			if (this.Confirm)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0003188C File Offset: 0x0002FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectBossId != 0U)
			{
				this.SelectBossId = other.SelectBossId;
			}
			this.cellMonsterList_.Add(other.cellMonsterList_);
			if (other.Confirm)
			{
				this.Confirm = other.Confirm;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000318ED File Offset: 0x0002FAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000318F8 File Offset: 0x0002FAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Confirm = input.ReadBool();
						}
					}
					else
					{
						this.SelectBossId = input.ReadUInt32();
					}
				}
				else
				{
					this.cellMonsterList_.AddEntriesFrom(ref input, CellMonsterInfo._repeated_cellMonsterList_codec);
				}
			}
		}

		// Token: 0x04000726 RID: 1830
		private static readonly MessageParser<CellMonsterInfo> _parser = new MessageParser<CellMonsterInfo>(() => new CellMonsterInfo());

		// Token: 0x04000727 RID: 1831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000728 RID: 1832
		public const int SelectBossIdFieldNumber = 12;

		// Token: 0x04000729 RID: 1833
		private uint selectBossId_;

		// Token: 0x0400072A RID: 1834
		public const int CellMonsterListFieldNumber = 3;

		// Token: 0x0400072B RID: 1835
		private static readonly FieldCodec<CellMonster> _repeated_cellMonsterList_codec = FieldCodec.ForMessage<CellMonster>(26U, CellMonster.Parser);

		// Token: 0x0400072C RID: 1836
		private readonly RepeatedField<CellMonster> cellMonsterList_ = new RepeatedField<CellMonster>();

		// Token: 0x0400072D RID: 1837
		public const int ConfirmFieldNumber = 13;

		// Token: 0x0400072E RID: 1838
		private bool confirm_;
	}
}
