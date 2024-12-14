using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009EF RID: 2543
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveAetherDivideSceneScRsp : IMessage<LeaveAetherDivideSceneScRsp>, IMessage, IEquatable<LeaveAetherDivideSceneScRsp>, IDeepCloneable<LeaveAetherDivideSceneScRsp>, IBufferMessage
	{
		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x060070E7 RID: 28903 RVA: 0x0012CE84 File Offset: 0x0012B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveAetherDivideSceneScRsp> Parser
		{
			get
			{
				return LeaveAetherDivideSceneScRsp._parser;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x0012CE8B File Offset: 0x0012B08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveAetherDivideSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x0012CE9D File Offset: 0x0012B09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveAetherDivideSceneScRsp.Descriptor;
			}
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x0012CEA4 File Offset: 0x0012B0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneScRsp()
		{
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x0012CEAC File Offset: 0x0012B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneScRsp(LeaveAetherDivideSceneScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x0012CED1 File Offset: 0x0012B0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAetherDivideSceneScRsp Clone()
		{
			return new LeaveAetherDivideSceneScRsp(this);
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060070ED RID: 28909 RVA: 0x0012CED9 File Offset: 0x0012B0D9
		// (set) Token: 0x060070EE RID: 28910 RVA: 0x0012CEE1 File Offset: 0x0012B0E1
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

		// Token: 0x060070EF RID: 28911 RVA: 0x0012CEEA File Offset: 0x0012B0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveAetherDivideSceneScRsp);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0012CEF8 File Offset: 0x0012B0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveAetherDivideSceneScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x0012CF28 File Offset: 0x0012B128
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

		// Token: 0x060070F2 RID: 28914 RVA: 0x0012CF67 File Offset: 0x0012B167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0012CF6F File Offset: 0x0012B16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0012CF78 File Offset: 0x0012B178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x0012CFAC File Offset: 0x0012B1AC
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

		// Token: 0x060070F6 RID: 28918 RVA: 0x0012CFEA File Offset: 0x0012B1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveAetherDivideSceneScRsp other)
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

		// Token: 0x060070F7 RID: 28919 RVA: 0x0012D01B File Offset: 0x0012B21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x0012D024 File Offset: 0x0012B224
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
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B82 RID: 11138
		private static readonly MessageParser<LeaveAetherDivideSceneScRsp> _parser = new MessageParser<LeaveAetherDivideSceneScRsp>(() => new LeaveAetherDivideSceneScRsp());

		// Token: 0x04002B83 RID: 11139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B84 RID: 11140
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04002B85 RID: 11141
		private uint retcode_;
	}
}
