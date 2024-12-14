using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001403 RID: 5123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpgradeAreaScRsp : IMessage<UpgradeAreaScRsp>, IMessage, IEquatable<UpgradeAreaScRsp>, IDeepCloneable<UpgradeAreaScRsp>, IBufferMessage
	{
		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x0600E46E RID: 58478 RVA: 0x0025F588 File Offset: 0x0025D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpgradeAreaScRsp> Parser
		{
			get
			{
				return UpgradeAreaScRsp._parser;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x0600E46F RID: 58479 RVA: 0x0025F58F File Offset: 0x0025D78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0600E470 RID: 58480 RVA: 0x0025F5A1 File Offset: 0x0025D7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpgradeAreaScRsp.Descriptor;
			}
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x0025F5A8 File Offset: 0x0025D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaScRsp()
		{
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x0025F5B0 File Offset: 0x0025D7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaScRsp(UpgradeAreaScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.areaId_ = other.areaId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x0025F5ED File Offset: 0x0025D7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaScRsp Clone()
		{
			return new UpgradeAreaScRsp(this);
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0600E474 RID: 58484 RVA: 0x0025F5F5 File Offset: 0x0025D7F5
		// (set) Token: 0x0600E475 RID: 58485 RVA: 0x0025F5FD File Offset: 0x0025D7FD
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

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0600E476 RID: 58486 RVA: 0x0025F606 File Offset: 0x0025D806
		// (set) Token: 0x0600E477 RID: 58487 RVA: 0x0025F60E File Offset: 0x0025D80E
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

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x0025F617 File Offset: 0x0025D817
		// (set) Token: 0x0600E479 RID: 58489 RVA: 0x0025F61F File Offset: 0x0025D81F
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

		// Token: 0x0600E47A RID: 58490 RVA: 0x0025F628 File Offset: 0x0025D828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpgradeAreaScRsp);
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x0025F638 File Offset: 0x0025D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpgradeAreaScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.AreaId == other.AreaId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x0025F694 File Offset: 0x0025D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x0025F705 File Offset: 0x0025D905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x0025F70D File Offset: 0x0025D90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x0025F718 File Offset: 0x0025D918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x0025F790 File Offset: 0x0025D990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x0025F800 File Offset: 0x0025DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpgradeAreaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x0025F864 File Offset: 0x0025DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x0025F870 File Offset: 0x0025DA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AreaId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005ABC RID: 23228
		private static readonly MessageParser<UpgradeAreaScRsp> _parser = new MessageParser<UpgradeAreaScRsp>(() => new UpgradeAreaScRsp());

		// Token: 0x04005ABD RID: 23229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ABE RID: 23230
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04005ABF RID: 23231
		private uint retcode_;

		// Token: 0x04005AC0 RID: 23232
		public const int AreaIdFieldNumber = 7;

		// Token: 0x04005AC1 RID: 23233
		private uint areaId_;

		// Token: 0x04005AC2 RID: 23234
		public const int LevelFieldNumber = 2;

		// Token: 0x04005AC3 RID: 23235
		private uint level_;
	}
}
