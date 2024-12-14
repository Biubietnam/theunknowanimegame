using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD7 RID: 2775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Mission : IMessage<Mission>, IMessage, IEquatable<Mission>, IDeepCloneable<Mission>, IBufferMessage
	{
		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x001457C1 File Offset: 0x001439C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Mission> Parser
		{
			get
			{
				return Mission._parser;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x001457C8 File Offset: 0x001439C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x001457DA File Offset: 0x001439DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mission.Descriptor;
			}
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x001457E1 File Offset: 0x001439E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mission()
		{
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x001457E9 File Offset: 0x001439E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mission(Mission other) : this()
		{
			this.progress_ = other.progress_;
			this.status_ = other.status_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00145826 File Offset: 0x00143A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mission Clone()
		{
			return new Mission(this);
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x0014582E File Offset: 0x00143A2E
		// (set) Token: 0x06007AF5 RID: 31477 RVA: 0x00145836 File Offset: 0x00143A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x0014583F File Offset: 0x00143A3F
		// (set) Token: 0x06007AF7 RID: 31479 RVA: 0x00145847 File Offset: 0x00143A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x00145850 File Offset: 0x00143A50
		// (set) Token: 0x06007AF9 RID: 31481 RVA: 0x00145858 File Offset: 0x00143A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x00145861 File Offset: 0x00143A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Mission);
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x00145870 File Offset: 0x00143A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Mission other)
		{
			return other != null && (other == this || (this.Progress == other.Progress && this.Status == other.Status && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x001458CC File Offset: 0x00143ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Status != MissionStatus.MissionNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x00145943 File Offset: 0x00143B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x0014594B File Offset: 0x00143B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x00145954 File Offset: 0x00143B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Progress);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Id);
			}
			if (this.Status != MissionStatus.MissionNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x001459CC File Offset: 0x00143BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.Status != MissionStatus.MissionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x00145A3C File Offset: 0x00143C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Mission other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.Status != MissionStatus.MissionNone)
			{
				this.Status = other.Status;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x00145AA0 File Offset: 0x00143CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x00145AAC File Offset: 0x00143CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = (MissionStatus)input.ReadEnum();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Progress = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002F2B RID: 12075
		private static readonly MessageParser<Mission> _parser = new MessageParser<Mission>(() => new Mission());

		// Token: 0x04002F2C RID: 12076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F2D RID: 12077
		public const int ProgressFieldNumber = 3;

		// Token: 0x04002F2E RID: 12078
		private uint progress_;

		// Token: 0x04002F2F RID: 12079
		public const int StatusFieldNumber = 8;

		// Token: 0x04002F30 RID: 12080
		private MissionStatus status_;

		// Token: 0x04002F31 RID: 12081
		public const int IdFieldNumber = 6;

		// Token: 0x04002F32 RID: 12082
		private uint id_;
	}
}
