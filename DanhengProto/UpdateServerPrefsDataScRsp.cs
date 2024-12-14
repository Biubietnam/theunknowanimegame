using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FB RID: 5115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateServerPrefsDataScRsp : IMessage<UpdateServerPrefsDataScRsp>, IMessage, IEquatable<UpdateServerPrefsDataScRsp>, IDeepCloneable<UpdateServerPrefsDataScRsp>, IBufferMessage
	{
		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x0025E6ED File Offset: 0x0025C8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateServerPrefsDataScRsp> Parser
		{
			get
			{
				return UpdateServerPrefsDataScRsp._parser;
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x0600E40F RID: 58383 RVA: 0x0025E6F4 File Offset: 0x0025C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateServerPrefsDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x0600E410 RID: 58384 RVA: 0x0025E706 File Offset: 0x0025C906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateServerPrefsDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x0025E70D File Offset: 0x0025C90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataScRsp()
		{
		}

		// Token: 0x0600E412 RID: 58386 RVA: 0x0025E715 File Offset: 0x0025C915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataScRsp(UpdateServerPrefsDataScRsp other) : this()
		{
			this.serverPrefsId_ = other.serverPrefsId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x0025E746 File Offset: 0x0025C946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataScRsp Clone()
		{
			return new UpdateServerPrefsDataScRsp(this);
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0600E414 RID: 58388 RVA: 0x0025E74E File Offset: 0x0025C94E
		// (set) Token: 0x0600E415 RID: 58389 RVA: 0x0025E756 File Offset: 0x0025C956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ServerPrefsId
		{
			get
			{
				return this.serverPrefsId_;
			}
			set
			{
				this.serverPrefsId_ = value;
			}
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0600E416 RID: 58390 RVA: 0x0025E75F File Offset: 0x0025C95F
		// (set) Token: 0x0600E417 RID: 58391 RVA: 0x0025E767 File Offset: 0x0025C967
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

		// Token: 0x0600E418 RID: 58392 RVA: 0x0025E770 File Offset: 0x0025C970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateServerPrefsDataScRsp);
		}

		// Token: 0x0600E419 RID: 58393 RVA: 0x0025E77E File Offset: 0x0025C97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateServerPrefsDataScRsp other)
		{
			return other != null && (other == this || (this.ServerPrefsId == other.ServerPrefsId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x0025E7BC File Offset: 0x0025C9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerPrefsId != 0U)
			{
				num ^= this.ServerPrefsId.GetHashCode();
			}
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

		// Token: 0x0600E41B RID: 58395 RVA: 0x0025E814 File Offset: 0x0025CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x0025E81C File Offset: 0x0025CA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x0025E828 File Offset: 0x0025CA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerPrefsId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ServerPrefsId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x0025E884 File Offset: 0x0025CA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerPrefsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServerPrefsId);
			}
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

		// Token: 0x0600E41F RID: 58399 RVA: 0x0025E8DC File Offset: 0x0025CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateServerPrefsDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerPrefsId != 0U)
			{
				this.ServerPrefsId = other.ServerPrefsId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x0025E92C File Offset: 0x0025CB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x0025E938 File Offset: 0x0025CB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 96U)
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
					this.ServerPrefsId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A9C RID: 23196
		private static readonly MessageParser<UpdateServerPrefsDataScRsp> _parser = new MessageParser<UpdateServerPrefsDataScRsp>(() => new UpdateServerPrefsDataScRsp());

		// Token: 0x04005A9D RID: 23197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A9E RID: 23198
		public const int ServerPrefsIdFieldNumber = 9;

		// Token: 0x04005A9F RID: 23199
		private uint serverPrefsId_;

		// Token: 0x04005AA0 RID: 23200
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005AA1 RID: 23201
		private uint retcode_;
	}
}
