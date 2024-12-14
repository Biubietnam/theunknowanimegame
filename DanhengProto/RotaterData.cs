using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001043 RID: 4163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RotaterData : IMessage<RotaterData>, IMessage, IEquatable<RotaterData>, IDeepCloneable<RotaterData>, IBufferMessage
	{
		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600B931 RID: 47409 RVA: 0x001F13AC File Offset: 0x001EF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RotaterData> Parser
		{
			get
			{
				return RotaterData._parser;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x001F13B3 File Offset: 0x001EF5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RotaterDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600B933 RID: 47411 RVA: 0x001F13C5 File Offset: 0x001EF5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotaterData.Descriptor;
			}
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x001F13CC File Offset: 0x001EF5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData()
		{
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x001F13D4 File Offset: 0x001EF5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData(RotaterData other) : this()
		{
			this.groupId_ = other.groupId_;
			this.gMCFBLFAFFO_ = other.gMCFBLFAFFO_;
			this.lENPGCPMGCL_ = other.lENPGCPMGCL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x001F1411 File Offset: 0x001EF611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData Clone()
		{
			return new RotaterData(this);
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x001F1419 File Offset: 0x001EF619
		// (set) Token: 0x0600B938 RID: 47416 RVA: 0x001F1421 File Offset: 0x001EF621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600B939 RID: 47417 RVA: 0x001F142A File Offset: 0x001EF62A
		// (set) Token: 0x0600B93A RID: 47418 RVA: 0x001F1432 File Offset: 0x001EF632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMCFBLFAFFO
		{
			get
			{
				return this.gMCFBLFAFFO_;
			}
			set
			{
				this.gMCFBLFAFFO_ = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600B93B RID: 47419 RVA: 0x001F143B File Offset: 0x001EF63B
		// (set) Token: 0x0600B93C RID: 47420 RVA: 0x001F1443 File Offset: 0x001EF643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LENPGCPMGCL
		{
			get
			{
				return this.lENPGCPMGCL_;
			}
			set
			{
				this.lENPGCPMGCL_ = value;
			}
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x001F144C File Offset: 0x001EF64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotaterData);
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x001F145C File Offset: 0x001EF65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotaterData other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.GMCFBLFAFFO == other.GMCFBLFAFFO && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LENPGCPMGCL, other.LENPGCPMGCL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x001F14C0 File Offset: 0x001EF6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.GMCFBLFAFFO != 0U)
			{
				num ^= this.GMCFBLFAFFO.GetHashCode();
			}
			if (this.LENPGCPMGCL != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LENPGCPMGCL);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x001F1538 File Offset: 0x001EF738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x001F1540 File Offset: 0x001EF740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x001F154C File Offset: 0x001EF74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LENPGCPMGCL != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.LENPGCPMGCL);
			}
			if (this.GMCFBLFAFFO != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GMCFBLFAFFO);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x001F15C8 File Offset: 0x001EF7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.GMCFBLFAFFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMCFBLFAFFO);
			}
			if (this.LENPGCPMGCL != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x001F1630 File Offset: 0x001EF830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotaterData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.GMCFBLFAFFO != 0U)
			{
				this.GMCFBLFAFFO = other.GMCFBLFAFFO;
			}
			if (other.LENPGCPMGCL != 0f)
			{
				this.LENPGCPMGCL = other.LENPGCPMGCL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x001F1699 File Offset: 0x001EF899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x001F16A4 File Offset: 0x001EF8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 21U)
				{
					if (num != 40U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.GMCFBLFAFFO = input.ReadUInt32();
					}
				}
				else
				{
					this.LENPGCPMGCL = input.ReadFloat();
				}
			}
		}

		// Token: 0x04004B04 RID: 19204
		private static readonly MessageParser<RotaterData> _parser = new MessageParser<RotaterData>(() => new RotaterData());

		// Token: 0x04004B05 RID: 19205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B06 RID: 19206
		public const int GroupIdFieldNumber = 12;

		// Token: 0x04004B07 RID: 19207
		private uint groupId_;

		// Token: 0x04004B08 RID: 19208
		public const int GMCFBLFAFFOFieldNumber = 5;

		// Token: 0x04004B09 RID: 19209
		private uint gMCFBLFAFFO_;

		// Token: 0x04004B0A RID: 19210
		public const int LENPGCPMGCLFieldNumber = 2;

		// Token: 0x04004B0B RID: 19211
		private float lENPGCPMGCL_;
	}
}
