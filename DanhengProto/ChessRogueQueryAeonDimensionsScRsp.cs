using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200026D RID: 621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryAeonDimensionsScRsp : IMessage<ChessRogueQueryAeonDimensionsScRsp>, IMessage, IEquatable<ChessRogueQueryAeonDimensionsScRsp>, IDeepCloneable<ChessRogueQueryAeonDimensionsScRsp>, IBufferMessage
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0004F9AB File Offset: 0x0004DBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryAeonDimensionsScRsp> Parser
		{
			get
			{
				return ChessRogueQueryAeonDimensionsScRsp._parser;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0004F9B2 File Offset: 0x0004DBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonDimensionsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0004F9C4 File Offset: 0x0004DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryAeonDimensionsScRsp.Descriptor;
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0004F9CB File Offset: 0x0004DBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsScRsp()
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0004F9D4 File Offset: 0x0004DBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsScRsp(ChessRogueQueryAeonDimensionsScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0004FA20 File Offset: 0x0004DC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsScRsp Clone()
		{
			return new ChessRogueQueryAeonDimensionsScRsp(this);
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0004FA28 File Offset: 0x0004DC28
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0004FA30 File Offset: 0x0004DC30
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

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0004FA39 File Offset: 0x0004DC39
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0004FA41 File Offset: 0x0004DC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0004FA4A File Offset: 0x0004DC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryAeonDimensionsScRsp);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0004FA58 File Offset: 0x0004DC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryAeonDimensionsScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0004FAFD File Offset: 0x0004DCFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0004FB05 File Offset: 0x0004DD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0004FB10 File Offset: 0x0004DD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0004FB6C File Offset: 0x0004DD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryAeonDimensionsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueQueryAeonInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0004FC38 File Offset: 0x0004DE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
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
				else
				{
					if (this.info_ == null)
					{
						this.Info = new ChessRogueQueryAeonInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly MessageParser<ChessRogueQueryAeonDimensionsScRsp> _parser = new MessageParser<ChessRogueQueryAeonDimensionsScRsp>(() => new ChessRogueQueryAeonDimensionsScRsp());

		// Token: 0x04000BA2 RID: 2978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BA3 RID: 2979
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04000BA4 RID: 2980
		private uint retcode_;

		// Token: 0x04000BA5 RID: 2981
		public const int InfoFieldNumber = 1;

		// Token: 0x04000BA6 RID: 2982
		private ChessRogueQueryAeonInfo info_;
	}
}
