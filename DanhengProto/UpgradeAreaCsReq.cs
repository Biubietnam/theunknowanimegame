using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001401 RID: 5121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpgradeAreaCsReq : IMessage<UpgradeAreaCsReq>, IMessage, IEquatable<UpgradeAreaCsReq>, IDeepCloneable<UpgradeAreaCsReq>, IBufferMessage
	{
		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0600E457 RID: 58455 RVA: 0x0025F24C File Offset: 0x0025D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpgradeAreaCsReq> Parser
		{
			get
			{
				return UpgradeAreaCsReq._parser;
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0600E458 RID: 58456 RVA: 0x0025F253 File Offset: 0x0025D453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x0600E459 RID: 58457 RVA: 0x0025F265 File Offset: 0x0025D465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpgradeAreaCsReq.Descriptor;
			}
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x0025F26C File Offset: 0x0025D46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaCsReq()
		{
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x0025F274 File Offset: 0x0025D474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaCsReq(UpgradeAreaCsReq other) : this()
		{
			this.level_ = other.level_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x0025F2A5 File Offset: 0x0025D4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaCsReq Clone()
		{
			return new UpgradeAreaCsReq(this);
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x0600E45D RID: 58461 RVA: 0x0025F2AD File Offset: 0x0025D4AD
		// (set) Token: 0x0600E45E RID: 58462 RVA: 0x0025F2B5 File Offset: 0x0025D4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x0600E45F RID: 58463 RVA: 0x0025F2BE File Offset: 0x0025D4BE
		// (set) Token: 0x0600E460 RID: 58464 RVA: 0x0025F2C6 File Offset: 0x0025D4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x0025F2CF File Offset: 0x0025D4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpgradeAreaCsReq);
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x0025F2DD File Offset: 0x0025D4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpgradeAreaCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x0025F31C File Offset: 0x0025D51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x0025F374 File Offset: 0x0025D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x0025F37C File Offset: 0x0025D57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x0025F388 File Offset: 0x0025D588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AreaId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x0025F3E4 File Offset: 0x0025D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x0025F43C File Offset: 0x0025D63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpgradeAreaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x0025F48C File Offset: 0x0025D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x0025F498 File Offset: 0x0025D698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005AB5 RID: 23221
		private static readonly MessageParser<UpgradeAreaCsReq> _parser = new MessageParser<UpgradeAreaCsReq>(() => new UpgradeAreaCsReq());

		// Token: 0x04005AB6 RID: 23222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB7 RID: 23223
		public const int LevelFieldNumber = 13;

		// Token: 0x04005AB8 RID: 23224
		private uint level_;

		// Token: 0x04005AB9 RID: 23225
		public const int AreaIdFieldNumber = 5;

		// Token: 0x04005ABA RID: 23226
		private uint areaId_;
	}
}
