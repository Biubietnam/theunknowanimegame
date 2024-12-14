using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001117 RID: 4375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMissionEventProgressScRsp : IMessage<SetMissionEventProgressScRsp>, IMessage, IEquatable<SetMissionEventProgressScRsp>, IDeepCloneable<SetMissionEventProgressScRsp>, IBufferMessage
	{
		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600C314 RID: 49940 RVA: 0x0020BBA8 File Offset: 0x00209DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMissionEventProgressScRsp> Parser
		{
			get
			{
				return SetMissionEventProgressScRsp._parser;
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600C315 RID: 49941 RVA: 0x0020BBAF File Offset: 0x00209DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetMissionEventProgressScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600C316 RID: 49942 RVA: 0x0020BBC1 File Offset: 0x00209DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMissionEventProgressScRsp.Descriptor;
			}
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x0020BBC8 File Offset: 0x00209DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressScRsp()
		{
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x0020BBD0 File Offset: 0x00209DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressScRsp(SetMissionEventProgressScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x0020BBF5 File Offset: 0x00209DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressScRsp Clone()
		{
			return new SetMissionEventProgressScRsp(this);
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600C31A RID: 49946 RVA: 0x0020BBFD File Offset: 0x00209DFD
		// (set) Token: 0x0600C31B RID: 49947 RVA: 0x0020BC05 File Offset: 0x00209E05
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

		// Token: 0x0600C31C RID: 49948 RVA: 0x0020BC0E File Offset: 0x00209E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMissionEventProgressScRsp);
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x0020BC1C File Offset: 0x00209E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMissionEventProgressScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x0020BC4C File Offset: 0x00209E4C
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

		// Token: 0x0600C31F RID: 49951 RVA: 0x0020BC8B File Offset: 0x00209E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x0020BC93 File Offset: 0x00209E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x0020BC9C File Offset: 0x00209E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x0020BCD0 File Offset: 0x00209ED0
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

		// Token: 0x0600C323 RID: 49955 RVA: 0x0020BD0E File Offset: 0x00209F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMissionEventProgressScRsp other)
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

		// Token: 0x0600C324 RID: 49956 RVA: 0x0020BD3F File Offset: 0x00209F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x0020BD48 File Offset: 0x00209F48
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
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004ED9 RID: 20185
		private static readonly MessageParser<SetMissionEventProgressScRsp> _parser = new MessageParser<SetMissionEventProgressScRsp>(() => new SetMissionEventProgressScRsp());

		// Token: 0x04004EDA RID: 20186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EDB RID: 20187
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04004EDC RID: 20188
		private uint retcode_;
	}
}
