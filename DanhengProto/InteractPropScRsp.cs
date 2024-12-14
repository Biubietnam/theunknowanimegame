using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000939 RID: 2361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractPropScRsp : IMessage<InteractPropScRsp>, IMessage, IEquatable<InteractPropScRsp>, IDeepCloneable<InteractPropScRsp>, IBufferMessage
	{
		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x0011935D File Offset: 0x0011755D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractPropScRsp> Parser
		{
			get
			{
				return InteractPropScRsp._parser;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06006958 RID: 26968 RVA: 0x00119364 File Offset: 0x00117564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractPropScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x00119376 File Offset: 0x00117576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractPropScRsp.Descriptor;
			}
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x0011937D File Offset: 0x0011757D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropScRsp()
		{
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00119385 File Offset: 0x00117585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropScRsp(InteractPropScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.propState_ = other.propState_;
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x001193C2 File Offset: 0x001175C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractPropScRsp Clone()
		{
			return new InteractPropScRsp(this);
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x001193CA File Offset: 0x001175CA
		// (set) Token: 0x0600695E RID: 26974 RVA: 0x001193D2 File Offset: 0x001175D2
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

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001193DB File Offset: 0x001175DB
		// (set) Token: 0x06006960 RID: 26976 RVA: 0x001193E3 File Offset: 0x001175E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropState
		{
			get
			{
				return this.propState_;
			}
			set
			{
				this.propState_ = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x001193EC File Offset: 0x001175EC
		// (set) Token: 0x06006962 RID: 26978 RVA: 0x001193F4 File Offset: 0x001175F4
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

		// Token: 0x06006963 RID: 26979 RVA: 0x001193FD File Offset: 0x001175FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractPropScRsp);
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x0011940C File Offset: 0x0011760C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractPropScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.PropState == other.PropState && this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00119468 File Offset: 0x00117668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.PropState != 0U)
			{
				num ^= this.PropState.GetHashCode();
			}
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

		// Token: 0x06006966 RID: 26982 RVA: 0x001194D9 File Offset: 0x001176D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x001194E1 File Offset: 0x001176E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x001194EC File Offset: 0x001176EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.PropState != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PropState);
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

		// Token: 0x06006969 RID: 26985 RVA: 0x00119560 File Offset: 0x00117760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.PropState != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropState);
			}
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

		// Token: 0x0600696A RID: 26986 RVA: 0x001195D0 File Offset: 0x001177D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractPropScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.PropState != 0U)
			{
				this.PropState = other.PropState;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00119634 File Offset: 0x00117834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00119640 File Offset: 0x00117840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
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
						this.PropState = input.ReadUInt32();
					}
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400285F RID: 10335
		private static readonly MessageParser<InteractPropScRsp> _parser = new MessageParser<InteractPropScRsp>(() => new InteractPropScRsp());

		// Token: 0x04002860 RID: 10336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002861 RID: 10337
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002862 RID: 10338
		private uint retcode_;

		// Token: 0x04002863 RID: 10339
		public const int PropStateFieldNumber = 14;

		// Token: 0x04002864 RID: 10340
		private uint propState_;

		// Token: 0x04002865 RID: 10341
		public const int PropEntityIdFieldNumber = 1;

		// Token: 0x04002866 RID: 10342
		private uint propEntityId_;
	}
}
