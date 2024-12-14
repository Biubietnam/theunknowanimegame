using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200144B RID: 5195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeHexAvatarTargetInfo : IMessage<WorkbenchReforgeHexAvatarTargetInfo>, IMessage, IEquatable<WorkbenchReforgeHexAvatarTargetInfo>, IDeepCloneable<WorkbenchReforgeHexAvatarTargetInfo>, IBufferMessage
	{
		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x0026878D File Offset: 0x0026698D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeHexAvatarTargetInfo> Parser
		{
			get
			{
				return WorkbenchReforgeHexAvatarTargetInfo._parser;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x0600E7DE RID: 59358 RVA: 0x00268794 File Offset: 0x00266994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeHexAvatarTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x002687A6 File Offset: 0x002669A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeHexAvatarTargetInfo.Descriptor;
			}
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x002687AD File Offset: 0x002669AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarTargetInfo()
		{
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x002687B5 File Offset: 0x002669B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarTargetInfo(WorkbenchReforgeHexAvatarTargetInfo other) : this()
		{
			this.targetReforgeHexId_ = other.targetReforgeHexId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x002687DA File Offset: 0x002669DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarTargetInfo Clone()
		{
			return new WorkbenchReforgeHexAvatarTargetInfo(this);
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x002687E2 File Offset: 0x002669E2
		// (set) Token: 0x0600E7E4 RID: 59364 RVA: 0x002687EA File Offset: 0x002669EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetReforgeHexId
		{
			get
			{
				return this.targetReforgeHexId_;
			}
			set
			{
				this.targetReforgeHexId_ = value;
			}
		}

		// Token: 0x0600E7E5 RID: 59365 RVA: 0x002687F3 File Offset: 0x002669F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeHexAvatarTargetInfo);
		}

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00268801 File Offset: 0x00266A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeHexAvatarTargetInfo other)
		{
			return other != null && (other == this || (this.TargetReforgeHexId == other.TargetReforgeHexId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00268830 File Offset: 0x00266A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetReforgeHexId != 0U)
			{
				num ^= this.TargetReforgeHexId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x0026886F File Offset: 0x00266A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00268877 File Offset: 0x00266A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x00268880 File Offset: 0x00266A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetReforgeHexId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TargetReforgeHexId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x002688B4 File Offset: 0x00266AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetReforgeHexId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetReforgeHexId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7EC RID: 59372 RVA: 0x002688F2 File Offset: 0x00266AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeHexAvatarTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetReforgeHexId != 0U)
			{
				this.TargetReforgeHexId = other.TargetReforgeHexId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x00268923 File Offset: 0x00266B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7EE RID: 59374 RVA: 0x0026892C File Offset: 0x00266B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetReforgeHexId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BFD RID: 23549
		private static readonly MessageParser<WorkbenchReforgeHexAvatarTargetInfo> _parser = new MessageParser<WorkbenchReforgeHexAvatarTargetInfo>(() => new WorkbenchReforgeHexAvatarTargetInfo());

		// Token: 0x04005BFE RID: 23550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BFF RID: 23551
		public const int TargetReforgeHexIdFieldNumber = 6;

		// Token: 0x04005C00 RID: 23552
		private uint targetReforgeHexId_;
	}
}
