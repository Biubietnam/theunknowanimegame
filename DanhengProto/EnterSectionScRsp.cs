using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000469 RID: 1129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSectionScRsp : IMessage<EnterSectionScRsp>, IMessage, IEquatable<EnterSectionScRsp>, IDeepCloneable<EnterSectionScRsp>, IBufferMessage
	{
		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x0008A5A8 File Offset: 0x000887A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSectionScRsp> Parser
		{
			get
			{
				return EnterSectionScRsp._parser;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x0008A5AF File Offset: 0x000887AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSectionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x0008A5C1 File Offset: 0x000887C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSectionScRsp.Descriptor;
			}
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0008A5C8 File Offset: 0x000887C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionScRsp()
		{
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0008A5D0 File Offset: 0x000887D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionScRsp(EnterSectionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x0008A5F5 File Offset: 0x000887F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSectionScRsp Clone()
		{
			return new EnterSectionScRsp(this);
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x0008A5FD File Offset: 0x000887FD
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x0008A605 File Offset: 0x00088805
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

		// Token: 0x0600324C RID: 12876 RVA: 0x0008A60E File Offset: 0x0008880E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSectionScRsp);
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0008A61C File Offset: 0x0008881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSectionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0008A64C File Offset: 0x0008884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0008A68B File Offset: 0x0008888B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x0008A693 File Offset: 0x00088893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x0008A69C File Offset: 0x0008889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x0008A6D0 File Offset: 0x000888D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x0008A70E File Offset: 0x0008890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSectionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x0008A73F File Offset: 0x0008893F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x0008A748 File Offset: 0x00088948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001408 RID: 5128
		private static readonly MessageParser<EnterSectionScRsp> _parser = new MessageParser<EnterSectionScRsp>(() => new EnterSectionScRsp());

		// Token: 0x04001409 RID: 5129
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400140A RID: 5130
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400140B RID: 5131
		private uint retcode_;
	}
}
