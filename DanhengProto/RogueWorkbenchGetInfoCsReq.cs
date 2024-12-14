using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001033 RID: 4147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchGetInfoCsReq : IMessage<RogueWorkbenchGetInfoCsReq>, IMessage, IEquatable<RogueWorkbenchGetInfoCsReq>, IDeepCloneable<RogueWorkbenchGetInfoCsReq>, IBufferMessage
	{
		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600B870 RID: 47216 RVA: 0x001EF3B0 File Offset: 0x001ED5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchGetInfoCsReq> Parser
		{
			get
			{
				return RogueWorkbenchGetInfoCsReq._parser;
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x001EF3B7 File Offset: 0x001ED5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchGetInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600B872 RID: 47218 RVA: 0x001EF3C9 File Offset: 0x001ED5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchGetInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x001EF3D0 File Offset: 0x001ED5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoCsReq()
		{
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x001EF3D8 File Offset: 0x001ED5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoCsReq(RogueWorkbenchGetInfoCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x001EF3FD File Offset: 0x001ED5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoCsReq Clone()
		{
			return new RogueWorkbenchGetInfoCsReq(this);
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600B876 RID: 47222 RVA: 0x001EF405 File Offset: 0x001ED605
		// (set) Token: 0x0600B877 RID: 47223 RVA: 0x001EF40D File Offset: 0x001ED60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x001EF416 File Offset: 0x001ED616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchGetInfoCsReq);
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x001EF424 File Offset: 0x001ED624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchGetInfoCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x001EF454 File Offset: 0x001ED654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x001EF493 File Offset: 0x001ED693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x001EF49B File Offset: 0x001ED69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x001EF4A4 File Offset: 0x001ED6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x001EF4D8 File Offset: 0x001ED6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x001EF516 File Offset: 0x001ED716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchGetInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x001EF547 File Offset: 0x001ED747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x001EF550 File Offset: 0x001ED750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004AC1 RID: 19137
		private static readonly MessageParser<RogueWorkbenchGetInfoCsReq> _parser = new MessageParser<RogueWorkbenchGetInfoCsReq>(() => new RogueWorkbenchGetInfoCsReq());

		// Token: 0x04004AC2 RID: 19138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC3 RID: 19139
		public const int PropEntityIdFieldNumber = 3;

		// Token: 0x04004AC4 RID: 19140
		private uint propEntityId_;
	}
}
