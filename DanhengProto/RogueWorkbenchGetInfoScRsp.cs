using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001035 RID: 4149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchGetInfoScRsp : IMessage<RogueWorkbenchGetInfoScRsp>, IMessage, IEquatable<RogueWorkbenchGetInfoScRsp>, IDeepCloneable<RogueWorkbenchGetInfoScRsp>, IBufferMessage
	{
		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x001EF664 File Offset: 0x001ED864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchGetInfoScRsp> Parser
		{
			get
			{
				return RogueWorkbenchGetInfoScRsp._parser;
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x001EF66B File Offset: 0x001ED86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchGetInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x001EF67D File Offset: 0x001ED87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchGetInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x001EF684 File Offset: 0x001ED884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoScRsp()
		{
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x001EF697 File Offset: 0x001ED897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoScRsp(RogueWorkbenchGetInfoScRsp other) : this()
		{
			this.funcInfoMap_ = other.funcInfoMap_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x001EF6CD File Offset: 0x001ED8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchGetInfoScRsp Clone()
		{
			return new RogueWorkbenchGetInfoScRsp(this);
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x001EF6D5 File Offset: 0x001ED8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, WorkbenchFuncInfo> FuncInfoMap
		{
			get
			{
				return this.funcInfoMap_;
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600B88C RID: 47244 RVA: 0x001EF6DD File Offset: 0x001ED8DD
		// (set) Token: 0x0600B88D RID: 47245 RVA: 0x001EF6E5 File Offset: 0x001ED8E5
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

		// Token: 0x0600B88E RID: 47246 RVA: 0x001EF6EE File Offset: 0x001ED8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchGetInfoScRsp);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x001EF6FC File Offset: 0x001ED8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchGetInfoScRsp other)
		{
			return other != null && (other == this || (this.FuncInfoMap.Equals(other.FuncInfoMap) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x001EF74C File Offset: 0x001ED94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.FuncInfoMap.GetHashCode();
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

		// Token: 0x0600B891 RID: 47249 RVA: 0x001EF799 File Offset: 0x001ED999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x001EF7A1 File Offset: 0x001ED9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x001EF7AC File Offset: 0x001ED9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funcInfoMap_.WriteTo(ref output, RogueWorkbenchGetInfoScRsp._map_funcInfoMap_codec);
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

		// Token: 0x0600B894 RID: 47252 RVA: 0x001EF7FC File Offset: 0x001ED9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funcInfoMap_.CalculateSize(RogueWorkbenchGetInfoScRsp._map_funcInfoMap_codec);
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

		// Token: 0x0600B895 RID: 47253 RVA: 0x001EF850 File Offset: 0x001EDA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchGetInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.funcInfoMap_.MergeFrom(other.funcInfoMap_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x001EF89D File Offset: 0x001EDA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x001EF8A8 File Offset: 0x001EDAA8
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
					this.funcInfoMap_.AddEntriesFrom(ref input, RogueWorkbenchGetInfoScRsp._map_funcInfoMap_codec);
				}
			}
		}

		// Token: 0x04004AC6 RID: 19142
		private static readonly MessageParser<RogueWorkbenchGetInfoScRsp> _parser = new MessageParser<RogueWorkbenchGetInfoScRsp>(() => new RogueWorkbenchGetInfoScRsp());

		// Token: 0x04004AC7 RID: 19143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC8 RID: 19144
		public const int FuncInfoMapFieldNumber = 1;

		// Token: 0x04004AC9 RID: 19145
		private static readonly MapField<uint, WorkbenchFuncInfo>.Codec _map_funcInfoMap_codec = new MapField<uint, WorkbenchFuncInfo>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<WorkbenchFuncInfo>(18U, WorkbenchFuncInfo.Parser), 10U);

		// Token: 0x04004ACA RID: 19146
		private readonly MapField<uint, WorkbenchFuncInfo> funcInfoMap_ = new MapField<uint, WorkbenchFuncInfo>();

		// Token: 0x04004ACB RID: 19147
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04004ACC RID: 19148
		private uint retcode_;
	}
}
