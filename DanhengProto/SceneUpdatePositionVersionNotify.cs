using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200108F RID: 4239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneUpdatePositionVersionNotify : IMessage<SceneUpdatePositionVersionNotify>, IMessage, IEquatable<SceneUpdatePositionVersionNotify>, IDeepCloneable<SceneUpdatePositionVersionNotify>, IBufferMessage
	{
		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600BD09 RID: 48393 RVA: 0x001FD991 File Offset: 0x001FBB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneUpdatePositionVersionNotify> Parser
		{
			get
			{
				return SceneUpdatePositionVersionNotify._parser;
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600BD0A RID: 48394 RVA: 0x001FD998 File Offset: 0x001FBB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneUpdatePositionVersionNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600BD0B RID: 48395 RVA: 0x001FD9AA File Offset: 0x001FBBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneUpdatePositionVersionNotify.Descriptor;
			}
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x001FD9B1 File Offset: 0x001FBBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUpdatePositionVersionNotify()
		{
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x001FD9B9 File Offset: 0x001FBBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUpdatePositionVersionNotify(SceneUpdatePositionVersionNotify other) : this()
		{
			this.posVersion_ = other.posVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x001FD9DE File Offset: 0x001FBBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUpdatePositionVersionNotify Clone()
		{
			return new SceneUpdatePositionVersionNotify(this);
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x001FD9E6 File Offset: 0x001FBBE6
		// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x001FD9EE File Offset: 0x001FBBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PosVersion
		{
			get
			{
				return this.posVersion_;
			}
			set
			{
				this.posVersion_ = value;
			}
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x001FD9F7 File Offset: 0x001FBBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneUpdatePositionVersionNotify);
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x001FDA05 File Offset: 0x001FBC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneUpdatePositionVersionNotify other)
		{
			return other != null && (other == this || (this.PosVersion == other.PosVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x001FDA34 File Offset: 0x001FBC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PosVersion != 0U)
			{
				num ^= this.PosVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x001FDA73 File Offset: 0x001FBC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x001FDA7B File Offset: 0x001FBC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x001FDA84 File Offset: 0x001FBC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosVersion != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PosVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x001FDAB8 File Offset: 0x001FBCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PosVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x001FDAF6 File Offset: 0x001FBCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneUpdatePositionVersionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PosVersion != 0U)
			{
				this.PosVersion = other.PosVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x001FDB27 File Offset: 0x001FBD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x001FDB30 File Offset: 0x001FBD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PosVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004CE2 RID: 19682
		private static readonly MessageParser<SceneUpdatePositionVersionNotify> _parser = new MessageParser<SceneUpdatePositionVersionNotify>(() => new SceneUpdatePositionVersionNotify());

		// Token: 0x04004CE3 RID: 19683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CE4 RID: 19684
		public const int PosVersionFieldNumber = 14;

		// Token: 0x04004CE5 RID: 19685
		private uint posVersion_;
	}
}
