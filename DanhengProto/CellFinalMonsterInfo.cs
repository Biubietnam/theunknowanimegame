using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000179 RID: 377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellFinalMonsterInfo : IMessage<CellFinalMonsterInfo>, IMessage, IEquatable<CellFinalMonsterInfo>, IDeepCloneable<CellFinalMonsterInfo>, IBufferMessage
	{
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0003097B File Offset: 0x0002EB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellFinalMonsterInfo> Parser
		{
			get
			{
				return CellFinalMonsterInfo._parser;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00030982 File Offset: 0x0002EB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellFinalMonsterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00030994 File Offset: 0x0002EB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellFinalMonsterInfo.Descriptor;
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0003099B File Offset: 0x0002EB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellFinalMonsterInfo()
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000309A4 File Offset: 0x0002EBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellFinalMonsterInfo(CellFinalMonsterInfo other) : this()
		{
			this.cellBossInfo_ = ((other.cellBossInfo_ != null) ? other.cellBossInfo_.Clone() : null);
			this.selectBossInfo_ = ((other.selectBossInfo_ != null) ? other.selectBossInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00030A00 File Offset: 0x0002EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellFinalMonsterInfo Clone()
		{
			return new CellFinalMonsterInfo(this);
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x00030A08 File Offset: 0x0002EC08
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00030A10 File Offset: 0x0002EC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterInfo CellBossInfo
		{
			get
			{
				return this.cellBossInfo_;
			}
			set
			{
				this.cellBossInfo_ = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00030A19 File Offset: 0x0002EC19
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00030A21 File Offset: 0x0002EC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterSelectInfo SelectBossInfo
		{
			get
			{
				return this.selectBossInfo_;
			}
			set
			{
				this.selectBossInfo_ = value;
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00030A2A File Offset: 0x0002EC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellFinalMonsterInfo);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00030A38 File Offset: 0x0002EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellFinalMonsterInfo other)
		{
			return other != null && (other == this || (object.Equals(this.CellBossInfo, other.CellBossInfo) && object.Equals(this.SelectBossInfo, other.SelectBossInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cellBossInfo_ != null)
			{
				num ^= this.CellBossInfo.GetHashCode();
			}
			if (this.selectBossInfo_ != null)
			{
				num ^= this.SelectBossInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00030ADE File Offset: 0x0002ECDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00030AE6 File Offset: 0x0002ECE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00030AF0 File Offset: 0x0002ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cellBossInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CellBossInfo);
			}
			if (this.selectBossInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SelectBossInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00030B4C File Offset: 0x0002ED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cellBossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CellBossInfo);
			}
			if (this.selectBossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectBossInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00030BA4 File Offset: 0x0002EDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellFinalMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cellBossInfo_ != null)
			{
				if (this.cellBossInfo_ == null)
				{
					this.CellBossInfo = new CellMonsterInfo();
				}
				this.CellBossInfo.MergeFrom(other.CellBossInfo);
			}
			if (other.selectBossInfo_ != null)
			{
				if (this.selectBossInfo_ == null)
				{
					this.SelectBossInfo = new CellMonsterSelectInfo();
				}
				this.SelectBossInfo.MergeFrom(other.SelectBossInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00030C24 File Offset: 0x0002EE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00030C30 File Offset: 0x0002EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.selectBossInfo_ == null)
						{
							this.SelectBossInfo = new CellMonsterSelectInfo();
						}
						input.ReadMessage(this.SelectBossInfo);
					}
				}
				else
				{
					if (this.cellBossInfo_ == null)
					{
						this.CellBossInfo = new CellMonsterInfo();
					}
					input.ReadMessage(this.CellBossInfo);
				}
			}
		}

		// Token: 0x0400070A RID: 1802
		private static readonly MessageParser<CellFinalMonsterInfo> _parser = new MessageParser<CellFinalMonsterInfo>(() => new CellFinalMonsterInfo());

		// Token: 0x0400070B RID: 1803
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400070C RID: 1804
		public const int CellBossInfoFieldNumber = 2;

		// Token: 0x0400070D RID: 1805
		private CellMonsterInfo cellBossInfo_;

		// Token: 0x0400070E RID: 1806
		public const int SelectBossInfoFieldNumber = 11;

		// Token: 0x0400070F RID: 1807
		private CellMonsterSelectInfo selectBossInfo_;
	}
}
