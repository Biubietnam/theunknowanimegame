using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001443 RID: 5187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeBuffTargetInfo : IMessage<WorkbenchReforgeBuffTargetInfo>, IMessage, IEquatable<WorkbenchReforgeBuffTargetInfo>, IDeepCloneable<WorkbenchReforgeBuffTargetInfo>, IBufferMessage
	{
		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x0600E77D RID: 59261 RVA: 0x0026788D File Offset: 0x00265A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeBuffTargetInfo> Parser
		{
			get
			{
				return WorkbenchReforgeBuffTargetInfo._parser;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0600E77E RID: 59262 RVA: 0x00267894 File Offset: 0x00265A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeBuffTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0600E77F RID: 59263 RVA: 0x002678A6 File Offset: 0x00265AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeBuffTargetInfo.Descriptor;
			}
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x002678AD File Offset: 0x00265AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffTargetInfo()
		{
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x002678B5 File Offset: 0x00265AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffTargetInfo(WorkbenchReforgeBuffTargetInfo other) : this()
		{
			this.targetReforgeBuffId_ = other.targetReforgeBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x002678DA File Offset: 0x00265ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffTargetInfo Clone()
		{
			return new WorkbenchReforgeBuffTargetInfo(this);
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0600E783 RID: 59267 RVA: 0x002678E2 File Offset: 0x00265AE2
		// (set) Token: 0x0600E784 RID: 59268 RVA: 0x002678EA File Offset: 0x00265AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetReforgeBuffId
		{
			get
			{
				return this.targetReforgeBuffId_;
			}
			set
			{
				this.targetReforgeBuffId_ = value;
			}
		}

		// Token: 0x0600E785 RID: 59269 RVA: 0x002678F3 File Offset: 0x00265AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeBuffTargetInfo);
		}

		// Token: 0x0600E786 RID: 59270 RVA: 0x00267901 File Offset: 0x00265B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeBuffTargetInfo other)
		{
			return other != null && (other == this || (this.TargetReforgeBuffId == other.TargetReforgeBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E787 RID: 59271 RVA: 0x00267930 File Offset: 0x00265B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetReforgeBuffId != 0U)
			{
				num ^= this.TargetReforgeBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x0026796F File Offset: 0x00265B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E789 RID: 59273 RVA: 0x00267977 File Offset: 0x00265B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E78A RID: 59274 RVA: 0x00267980 File Offset: 0x00265B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetReforgeBuffId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TargetReforgeBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E78B RID: 59275 RVA: 0x002679B4 File Offset: 0x00265BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetReforgeBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetReforgeBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E78C RID: 59276 RVA: 0x002679F2 File Offset: 0x00265BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeBuffTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetReforgeBuffId != 0U)
			{
				this.TargetReforgeBuffId = other.TargetReforgeBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x00267A23 File Offset: 0x00265C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x00267A2C File Offset: 0x00265C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetReforgeBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BDD RID: 23517
		private static readonly MessageParser<WorkbenchReforgeBuffTargetInfo> _parser = new MessageParser<WorkbenchReforgeBuffTargetInfo>(() => new WorkbenchReforgeBuffTargetInfo());

		// Token: 0x04005BDE RID: 23518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BDF RID: 23519
		public const int TargetReforgeBuffIdFieldNumber = 11;

		// Token: 0x04005BE0 RID: 23520
		private uint targetReforgeBuffId_;
	}
}
