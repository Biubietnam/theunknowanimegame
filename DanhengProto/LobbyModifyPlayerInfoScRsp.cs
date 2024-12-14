using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A4B RID: 2635
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyModifyPlayerInfoScRsp : IMessage<LobbyModifyPlayerInfoScRsp>, IMessage, IEquatable<LobbyModifyPlayerInfoScRsp>, IDeepCloneable<LobbyModifyPlayerInfoScRsp>, IBufferMessage
	{
		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x060074EF RID: 29935 RVA: 0x00136D38 File Offset: 0x00134F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyModifyPlayerInfoScRsp> Parser
		{
			get
			{
				return LobbyModifyPlayerInfoScRsp._parser;
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x060074F0 RID: 29936 RVA: 0x00136D3F File Offset: 0x00134F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyModifyPlayerInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060074F1 RID: 29937 RVA: 0x00136D51 File Offset: 0x00134F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyModifyPlayerInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00136D58 File Offset: 0x00134F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoScRsp()
		{
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00136D60 File Offset: 0x00134F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoScRsp(LobbyModifyPlayerInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00136D85 File Offset: 0x00134F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoScRsp Clone()
		{
			return new LobbyModifyPlayerInfoScRsp(this);
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060074F5 RID: 29941 RVA: 0x00136D8D File Offset: 0x00134F8D
		// (set) Token: 0x060074F6 RID: 29942 RVA: 0x00136D95 File Offset: 0x00134F95
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

		// Token: 0x060074F7 RID: 29943 RVA: 0x00136D9E File Offset: 0x00134F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyModifyPlayerInfoScRsp);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00136DAC File Offset: 0x00134FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyModifyPlayerInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00136DDC File Offset: 0x00134FDC
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

		// Token: 0x060074FA RID: 29946 RVA: 0x00136E1B File Offset: 0x0013501B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x00136E23 File Offset: 0x00135023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x00136E2C File Offset: 0x0013502C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x00136E60 File Offset: 0x00135060
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

		// Token: 0x060074FE RID: 29950 RVA: 0x00136E9E File Offset: 0x0013509E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyModifyPlayerInfoScRsp other)
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

		// Token: 0x060074FF RID: 29951 RVA: 0x00136ECF File Offset: 0x001350CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00136ED8 File Offset: 0x001350D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002CF5 RID: 11509
		private static readonly MessageParser<LobbyModifyPlayerInfoScRsp> _parser = new MessageParser<LobbyModifyPlayerInfoScRsp>(() => new LobbyModifyPlayerInfoScRsp());

		// Token: 0x04002CF6 RID: 11510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF7 RID: 11511
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002CF8 RID: 11512
		private uint retcode_;
	}
}
